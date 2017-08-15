using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;


namespace sma_wire_experiment
{
    public partial class sma_control_form : Form
    {
        SerialPort comPort;
        public sma_control_form()
        {
            InitializeComponent();
            comport_lister();
            arduino_interface arduino = new arduino_interface();
            status_lbl.Text =  arduino.get_hi_val().ToString();
            //status_lbl.Text =  arduino.SetComPort();
        }

        public void comport_lister()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comport_cb.Items.Add(port);
                comport_cb.SelectedIndex = 0;
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}

