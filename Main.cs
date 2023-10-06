using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGo.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblData.Text = "0";
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String snum;
            int num;

            snum = lblData.Text;
            if (snum != "")
            {
                num = Convert.ToInt32(snum);
            } else
            {
                num = 0;
            }
            num++;
            snum = Convert.ToString(num);
            lblData.Text = snum;

            if (lblData.Text != "" && lblData.Text.All(char.IsDigit))
            {
                lblData.Text = (Convert.ToInt32(lblData.Text) + 1).ToString();
            }
            else
            {
                lblData.Text = "1";
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fname = new OpenFileDialog();
            string inps;

            fname.InitialDirectory = "C:\\users\\katchins\\Downloads";
            fname.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            fname.FilterIndex = 2;
            fname.ShowDialog();

            if (fname.FileName != "")
            {
                lbxOutput.Focus();
                lbxOutput.Items.Clear();
                StreamReader inp = new StreamReader(fname.FileName);
                inps = inp.ReadLine();
                while (!inp.EndOfStream)
                {
                    lbxOutput.Items.Add(inps);
                    inps = inp.ReadLine();

                }

            }


        }
    }
}
