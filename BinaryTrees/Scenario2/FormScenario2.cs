using BinaryTrees.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BinaryTrees.Scenario2
{
    public partial class FormScenario2 : Form
    {
        public FormScenario2()
        {
            InitializeComponent();
            Icon = Resources.Tree;
        }
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            txtEjeX.Text = e.X.ToString();
            txtEjeY.Text = e.Y.ToString();
        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scenario2Draw scenario2Draw = new Scenario2Draw();

            panel1.Controls.Add(scenario2Draw);

            scenario2Draw.Location = new Point(this.Width / 2, 0);

            scenario2Draw.Show();

        }

        private void recorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = "Preorden: 50, 17, 12, 9, 14, 23, 19, 72, 54, 67, 76" +
                    "\nInorden: 9, 12, 14, 17, 19, 23, 50, 54, 67, 72, 76" +
                    "\nPostorden: 9, 14, 12, 19, 23, 17, 67, 54, 76, 72, 50";

            MessageBox.Show(r, "Recorridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu regresarMenu = new Menu();
            regresarMenu.Show();
            this.Close();
        }
    }
}
