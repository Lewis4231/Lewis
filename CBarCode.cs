using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorCs
{
    class CBarCode
    {
        private System.IO.Ports.SerialPort serBarCode;
        private string barcode;
        private bool blsSuccess;
        public bool IsSuccess
        {
            get { return blsSuccess; }
            set { blsSuccess = value; }
        }
        public CBarCode()
        {
            serBarCode = new System.IO.Ports.SerialPort();

            this.serBarCode.BaudRate = 9600;
            this.serBarCode.DataBits = 8;
            this.serBarCode.Parity = System.IO.Ports.Parity.None;
            this.serBarCode.PortName = "COM4";
            this.serBarCode.StopBits = System.IO.Ports.StopBits.One;
            this.serBarCode.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceiveCallBack);

            this.serBarCode.Open();
        }
        private void DataReceiveCallBack(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            barcode = this.serBarCode.ReadLine();
            blsSuccess = true;  
        }
        public void ReadCommand()
        {
            blsSuccess = false;
            serBarCode.WriteLine("<T/>");
        }
        public string GetData()
        {
            return barcode;
        }
    }
}
