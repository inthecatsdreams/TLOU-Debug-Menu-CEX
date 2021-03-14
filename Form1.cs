using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;

namespace tlou_debug_tool
{
    public partial class Form1 : Form
    {
        public static CCAPI console = new CCAPI();
        public bool connected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void connectAndAttach_Click(object sender, EventArgs e)
        {
            if (console.ConnectTarget())
            {
                connected = true;
                console.AttachProcess();
                label1.Text = "Status: Connected and Attached to the current process!";
                label1.ForeColor = Color.Green;
                connectAndAttach.Enabled = false;
            }

            else
            {
                MessageBox.Show("Couldn't connect to your console");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Status: Waiting connection";
            label1.ForeColor = Color.Red;
        }

        private void DebugM1_Click(object sender, EventArgs e)
        {

            uint offset = 0x3B2A0;
            byte[] buff = { 0x41, 0x9E };

            console.SetMemory(offset, buff);

        }

        private void DebugM2_Click(object sender, EventArgs e)
        {
            uint offset = 0x3BF9C;
            byte[] buff = { 0x41, 0x9E };

            console.SetMemory(offset, buff);
        }
    }
}
