using System;
using System.IO.Ports;
using System.Web;
using System.Web.Routing;

namespace MainSite
{
	public class Global : HttpApplication
	{
        SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);     
        public string takedData = "not have info";

		void Application_Start(object sender, EventArgs e)
		{
            port.Open();
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);                       					
		}

		void Application_End(object sender, EventArgs e)
		{
			port.Close();
		}

		void Application_Error(object sender, EventArgs e)
		{
			// Code that runs when an unhandled error occurs

		}

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {            
            try
            {
                System.Threading.Thread.Sleep(500);
                SerialPort sp = (SerialPort)sender;
                takedData = sp.ReadExisting();
                IncomingData.IncomingDataString = takedData;

                string[] split = takedData.Split('/');
                IncomingData.LastSensorId = Convert.ToInt32(split[0]);
                IncomingData.LastTakedTemp = Convert.ToInt32(split[1]);
            }
            catch (Exception e3)
            {
                Console.WriteLine("Sorry, we have a trouble: " + e3.Message);
                throw;
            }            
        }
	}
}
