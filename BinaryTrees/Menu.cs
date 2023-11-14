using BinaryTrees.Properties;
using BinaryTrees.Scenario2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTrees
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Icon = Resources.Tree;
        }

        private void btnScenario1_Click(object sender, EventArgs e)
        {
            FormScenario1 frm = new FormScenario1();
            frm.Show();
            this.Hide();
        }

        private void btnScenario2_Click(object sender, EventArgs e)
        {
            FormScenario2 frm = new FormScenario2();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
