using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    internal class MainClass
    {
        public static readonly string con_string = "Data Source=교수용PC; Initial Catalog=RM;Persist Security Info=True; User ID=sa; Password=1234;";
        public static SqlConnection con = new SqlConnection(con_string);


        //Methord to check user validation

        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false; //기본 False 설정

            string qry = @"Select * from users where username = '"+user+ "' and upass ='" + pass + "'  ";
            SqlCommand cmd = new SqlCommand(qry, con); //여기부터 3줄은 세트임
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0) //유저아이디 비밀번호 호출후 데이터가 1개 이상이면 TRUE
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }

            return isValid; //True or False 반납
        }
        //Create property for ysername

        public static string user;  

        public static string USER  //프로퍼티임 외부에서 따로 함수없이 불러올수있는 기능
        {
            get { return user; }
            private set {  user = value; }
        }
        //Methord for curd operation

        //Hashtable 은 불필요한 공간을 줄이기 위해 사용함
        //sqlcommand 는 sql서버에 어떠한 명령을 내리기 위해 사용함 
        //CommandText 속성이 해석될 방법을 나타내는 값을 가져오거나 설정합니다.
        //Dictionary안에 있는 데이터 확인시에 foreach(DictionaryEntry ?? in ??) 사용
        //AddwithValue는 query에 파라미터를 추가할때 사용
        public static int SQl(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if(con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if(con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }
        // For loading data from database

        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            //Serial no in gridview

            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for(int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();

                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;

            foreach(DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = frmMain.Instance.Size;
                Background.Location = frmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();

            }
        }
        //for cb fill

        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }
        
    }
}
