using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;
using System.IO;

namespace sma_wire_experiment
{
    public class arduino_interface
    {
        SerialPort currentPort;
        //sma_control_form main_form = new sma_control_form();
        bool portFound;

        int hi = 5;

        public int get_hi_val(){ return hi;}


        public bool SetComPort()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    currentPort = new SerialPort(port, 38400);
                    //if (DetectArduino())
                    //{
                    //    portFound = true;
                    //    break;
                    //}
                    //else
                    //{
                    //    portFound = false;



                    //}
                }
            }
            catch (Exception e)
            {
            }

            return portFound;
        }

        public void DetectArduino()
        {
            try
            {
     
            }
            catch (Exception e)
            {
                //return false;
            }
        }


    }
}
