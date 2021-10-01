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
    public partial class Form2 : Form
    {
        public int minW;
        public int maxW;

        public int minH;
        public int maxH;

        public int numEnemies;
        public int heroHealth;

        Map map;
        Form1 frm1;


        public Form2()
        {
            InitializeComponent();

            minW = int.Parse(txtBoxMinW.Text);
            maxW = int.Parse(txtBoxMaxW.Text);

            minH = int.Parse(txtBoxMinH.Text);
            maxH = int.Parse(txtBoxMaxH.Text);

            numEnemies = int.Parse(txtBoxNumEnemies.Text);
            heroHealth = int.Parse(txtBoxHeroHealth.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            map.GenerateMap();
            frm1.Show();
            this.Hide();
        }
    }
}
