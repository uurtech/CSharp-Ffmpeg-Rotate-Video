using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fileName = string.Empty;
        OpenFileDialog file = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            fileName = file.FileName;
            textBox1.Text = fileName;
        }
   
       
 //           0=90CounterCLockwise and Vertical Flip
 //1=90Clockwise 
 //2=90CounterClockwise 
 //3=90Clockwise and Vertical Flip
        private void button2_Click(object sender, EventArgs e)
        {
            string rotate = string.Empty;
            if (radioButton1.Checked)
            {
                rotate = "0";
            }
            if (radioButton2.Checked)
            {
                rotate = "1";
            }
            if (radioButton3.Checked)
            {
                rotate = "2";
            }
            if (radioButton4.Checked)
            {
                rotate = "3";
            }
            if (radioButton5.Checked)
            {
                rotate = "4";
            }
                Process process = new Process();
                process.StartInfo.FileName = "ffmpeg.exe";
                process.StartInfo.Arguments = "-i " + fileName + " -vf \"transpose = "+rotate+"\" " + fileName;
                process.Start();
        
           
        }
    }
}
