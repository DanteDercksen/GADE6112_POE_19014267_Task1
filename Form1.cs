using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_POE_19014267
{
    public partial class Form1 : Form
    {
        Form2 frm2 = new Form2();

        public string mapText;

        bool upPressed = false;
        bool downPressed = false;
        bool rightPressed = false;
        bool leftPressed = false;

        public bool UpMove
        {
            get { return upPressed; }
            set { upPressed = value; }
        }

        public bool DownMove
        {
            get { return downPressed; }
            set { downPressed = value; }
        }

        public bool RightMove
        {
            get { return rightPressed; }
            set { rightPressed = value; }
        }

        public bool LeftMove
        {
            get { return leftPressed; }
            set { leftPressed = value; }
        }

        public Form1()
        {
            InitializeComponent();
            lblMap.Text = mapText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Up Button
            upPressed = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2.Show();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            rightPressed = true;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            downPressed = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            leftPressed = true;
        }
    }
}
