using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Security.Policy;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using MySql.Data.MySqlClient;

namespace ComportSerial
{
    public partial class Form1 : Form
    {
        string sendWith;
        string dataIN;
        int dataINLength;
        int[] dataInDec;

        StreamWriter objStreamWriter;
        //string pathFile = @"C:\Users\admin\source\repos\ComportSerial\_My Source File\SerialData.txt";
        string pathFile;
        bool state_AppendText = true;

        MySqlConnection myConnection;
        MySqlCommand myCommand;

        #region My Own Method
        private void SaveDataToTxtFile()
        {
            if (saveToTxtFileToolStripMenuItem.Checked)
            {   //메모장에 글쓰기
                try
                {
                    objStreamWriter = new StreamWriter(pathFile, state_AppendText);  //pathFile 경로에 있는 해당 파일을 가져옴
                    if (toolStripComboBox_wrtieLineOrwriteText.Text == "WriteLine")
                    {
                        objStreamWriter.WriteLine(dataIN);  //dataIN에 있는 텍스트를 WriteLine 으로 작성함
                    }
                    else if (toolStripComboBox_wrtieLineOrwriteText.Text == "Write")
                    {
                        objStreamWriter.Write(dataIN + " ");  //dataIN에 있는 텍스트를 Write 으로 작성함
                    }
                    objStreamWriter.Close();  // 닫기
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }
        private void SaveDataToMySqlDatabase()
        {
            if (saveToMySQLDatabaeToolStripMenuItem.Checked)
            {
                try
                {  //MySql에 연결하는 명령문
                    myConnection = new MySqlConnection("server=localhost; username=root; password=; port=3306; database=database01");
                    myConnection.Open();

                    myCommand = new MySqlCommand(string.Format("INSERT INTO `table01` VALUES('{0}')", dataIN), myConnection);
                    myCommand.ExecuteNonQuery();

                    myConnection.Close();

                    RefreshDataGridViewForm2();
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        #region Custom EventHandler
        public delegate void UpdateDelegate(object sender, UpdateDataEventArgs args);

        public event UpdateDelegate UpdateDataEventHandler;

        public class UpdateDataEventArgs : EventArgs
        {

        }
        protected void RefreshDataGridViewForm2()
        {
            UpdateDataEventArgs args = new UpdateDataEventArgs();
            UpdateDataEventHandler.Invoke(this, args);
        }
        #endregion
        #region RX Data Format
        private string RxDataFormat(int[] dataInput)
        {
            string strOut = "";
            if (toolStripComboBox_RxDataFormat.Text == "Hex")
            {
                foreach(int element in dataInput)
                {
                    strOut += Convert.ToString(element, 16) + "\t";
                }
            }
            else if (toolStripComboBox_RxDataFormat.Text == "Decimal")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element) + "\t";
                }
            }
            else if (toolStripComboBox_RxDataFormat.Text == "Binary")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element, 2) + "\t";
                }
            }
            else if (toolStripComboBox_RxDataFormat.Text == "Char")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToChar(element);
                }
            }
            return strOut;
        }
        #endregion
        #region TX Data Format
        private void TxDataFormat()
        {
            if(toolStripComboBox_TxDataFormat.Text == "Char")
            {  // 시리얼 포트를 통해서 텍스트 박스에 있는 데이터 보내기
                serialPort1.Write(tBoxDataOut.Text);
                int dataOUTLength = tBoxDataOut.TextLength;
                lblDataOutLength.Text = string.Format("{0:00}", dataOUTLength);
            }
            else
            {
                string dataOutBuffer;
                int countComma = 0;
                string[] dataPrepareToSend;
                byte[] dataToSend;

                try
                {   //텍스트 박스안에있는 패키지 데이터를 변수로 옮기기
                    dataOutBuffer = tBoxDataOut.Text;
                    //콤마가 몇개있는지 검사하기
                    foreach(char c in dataOutBuffer) { if (c == ',') { countComma++; } }
                    //콤마개수를 길이로 하는 1차원 배열 만들기
                    dataPrepareToSend = new string[countComma];

                    countComma = 0;
                    foreach(char c in dataOutBuffer)
                    {
                        if ((c != ','))
                        {
                            dataPrepareToSend[countComma] += c;
                        }
                        else
                        {
                            countComma++;

                            if(countComma == dataPrepareToSend.GetLength(0)) { break; }
                        }
                    }
                    dataToSend = new byte[dataPrepareToSend.Length];

                    if (toolStripComboBox_TxDataFormat.Text == "Hex")
                    {
                        for(int a = 0; a < dataPrepareToSend.Length; a++)
                        {
                            dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 16);
                        }
                    }
                    else if (toolStripComboBox_TxDataFormat.Text == "Binary")
                    {
                        for (int a = 0; a < dataPrepareToSend.Length; a++)
                        {
                            dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 2);
                        }

                    }
                    else if (toolStripComboBox_TxDataFormat.Text == "Decimal")
                    {
                        for (int a = 0; a < dataPrepareToSend.Length; a++)
                        {
                            dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 10);
                        }
                    }

                    serialPort1.Write(dataToSend, 0, dataToSend.Length);

                    lblDataOutLength.Text = string.Format("{0:00}", dataToSend.Length);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }                
            }
        }
        private void TxSendData()
        {   //SendData 버튼 클릭시
            if (serialPort1.IsOpen) //시리얼 포트가 열려있으면
            {
                //dataOUT = tBoxDataOut.Text;    //변수 생성
                if (sendWith == "None")
                {
                    TxDataFormat();
                }
                else if (sendWith == @"Both (\r\n)")
                {
                    TxDataFormat();
                    serialPort1.Write("\r\n");
                }
                else if (sendWith == @"New Line (\n)")
                {
                    TxDataFormat();
                    serialPort1.Write("\n");

                }
                else if (sendWith == @"Carriage Return (\r)")
                {
                    TxDataFormat();
                    serialPort1.Write("\r");

                }
            }
            if (clearToolStripMenuItem.Checked)
            {
                if (tBoxDataOut.Text != "")
                {
                    tBoxDataOut.Text = "";
                }
            }
        }
        #endregion
        #endregion
        #region GUI Method
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chBoxDtrEnable.Checked = false; //기본값은  false 
            serialPort1.DtrEnable = false;
            chBoxRTSEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = true;
            sendWith = @"Both (\r\n)";
            toolStripComboBox_RxDataPosition.Text = "BOTTOM";
            toolStripComboBox_RxShowDataWith.Text = "Add to Old Data";
            toolStripComboBox_TxtEndLine.Text = @"Both (\r\n)";

            toolStripComboBox_appendOrOverwriteText.Text = "Append Text";
            toolStripComboBox_wrtieLineOrwriteText.Text = "WriteLine";

            pathFile = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            pathFile += @"\_My Source File\SerialData.txt";

            saveToTxtFileToolStripMenuItem.Checked = false;
            saveToMySQLDatabaeToolStripMenuItem.Checked = false;

            toolStripComboBox_RxDataFormat.Text = "Char";
            toolStripComboBox_TxDataFormat.Text = "Char";

            this.toolStripComboBox_TxDataFormat.ComboBox.SelectionChangeCommitted += new System.EventHandler(this.toolStripComboBox_TxDataFormat_SelectionChangeCommitted);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {  //Opne 버튼 클릭시 시리얼 포트 오픈하기
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception err)  //예외 상황
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {   //CLose 버튼 클릭시
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }

        }
        private void btnSendData_Click(object sender, EventArgs e)
        {
            TxSendData();
        }
        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            //None
            //Both
            //New Line
            //Carriage Return

            if (toolStripComboBox_TxtEndLine.Text == "None") sendWith = "None";
            else if (toolStripComboBox_TxtEndLine.Text == @"Both (\r\n)") sendWith = @"Both (\r\n)";
            else if (toolStripComboBox_TxtEndLine.Text == @"New Line (\n)") sendWith = @"New Line (\n)";
            else if (toolStripComboBox_TxtEndLine.Text == @"Carriage Return (\r)") sendWith = @"Carriage Return (\r)";
        }
        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {   //체크박스 체크시
            if (chBoxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else serialPort1.DtrEnable = false;                      
        }
        private void chBoxRTSEnable_CheckedChanged(object sender, EventArgs e)
        {   //체크박스 체크시
            if (chBoxRTSEnable.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else serialPort1.RtsEnable = false;
        }
        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) //엔터키 눌렀을때
            {
                // 엔터키 눌렀을때 소리 안나게 하지
                this.doSomething();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }            
        }
        private void doSomething()
        {
            TxSendData();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)  //데이터를 받았을때
        {
            //dataIN = serialPort1.ReadExisting();  //시리얼 포트로부터 현재 수신된 모든 데이터를 읽어 dataIN변수에 저장 

            List<int> dataBuffer = new List<int>();

            while(serialPort1.BytesToRead > 0)
            {
                try
                {
                    dataBuffer.Add(serialPort1.ReadByte());
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            dataINLength = dataBuffer.Count();
            dataInDec = new int[dataINLength];
            dataInDec = dataBuffer.ToArray();

            this.Invoke(new EventHandler(ShowData));  //메인 UI 스레드에서 ShowData 메서드를 호출함
        }
        private void ShowData(object sender, EventArgs e)
        {
            //int dataINLength = dataIN.Length;
            dataIN = RxDataFormat(dataInDec);
            lblDataInLength.Text = string.Format("{0:00}", dataINLength);
            if (toolStripComboBox_RxShowDataWith.Text == "Always Update") tBoxDataIN.Text = dataIN;  //dataIN에 저장된 데이터를 tBoxDataIN에 표시
            else if (toolStripComboBox_RxShowDataWith.Text == "Add to Old Data")
            {
                if(toolStripComboBox_RxDataPosition.Text == "TOP")
                {
                    tBoxDataIN.Text = tBoxDataIN.Text.Insert(0, dataIN);  //dataIN에 저장된 데이터를 tBoxDataIN에 계속 추가하여 표시
                }
                else if(toolStripComboBox_RxDataPosition.Text == "BOTTOM")
                {
                    tBoxDataIN.Text += dataIN;
                }                                
            }
            SaveDataToTxtFile();
            SaveDataToMySqlDatabase();
        }    
        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != "") tBoxDataIN.Text = "";
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Lewis K","Creator",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBox12.Width = panel1.Width - 224;
            groupBox12.Height = panel1.Height - 42;

            tBoxDataIN.Height = panel1.Height - 95;
        }
        private void toolStripComboBox_appendOrOverwriteText_DropDownClosed(object sender, EventArgs e)
        {
            if(toolStripComboBox_appendOrOverwriteText.Text == "Append Text")
            {
                state_AppendText = true;
            }
            else
            {
                state_AppendText = false;
            }
        }
        private void showDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2(this);
            objForm2.Show();
        }
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 objForm3 = new Form3(this);
            objForm3.Show();
            this.Hide();
        }
        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {
            if(toolStripComboBox_RxDataPosition.Text == "BOTTOM")
            {
                tBoxDataIN.SelectionStart = tBoxDataIN.Text.Length;
                tBoxDataIN.ScrollToCaret();
            }
        }
        private void cBoxCOMPORT_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();   //현재 컴퓨터에 연결된 모든 시리얼 포트의 이름을 문자열 배열로 반환함(네임스페이스 System.IO.Ports필요)
            cBoxCOMPORT.Items.Clear();
            cBoxCOMPORT.Items.AddRange(ports);   //ports에 들어있는 모든 문자열을 콤보박스에 추가함
        }
        private void tBoxDataOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (toolStripComboBox_TxDataFormat.Text == "Hex")
            {
                char uppercase = char.ToUpper(c);

                if (!char.IsDigit(uppercase) && uppercase != 8 && uppercase != 46 && uppercase != ',' && !(uppercase >= 65 && uppercase <= 70))
                {
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Decimal")
            {
                if (!char.IsDigit(c) && c != 8 && c != 46 && c != ',')
                {
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Binary")
            {
                if (c != 49 && c != 48 && c != 8 && c != 46 && c != ',')
                {
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Char") { }
        }
        private void toolStripComboBox_TxDataFormat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tBoxDataOut.Clear();

            string message = "If you are not using char data format, append the comma (,) after each byte data Otherwise, the byte data will ignore. \n" +
                "Example :\t255, -> One byte data \n" +
                "\t255,128,140, -> Two or more byte data \n" +
                "\t120,144,189, -> The 189 will ignore cause has no comma (,)";
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK);
        }

        #endregion
    }
}
