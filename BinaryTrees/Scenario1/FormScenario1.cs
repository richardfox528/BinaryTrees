using BinaryTrees.Properties;
using BinaryTrees.Scenario1;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BinaryTrees
{
    public partial class FormScenario1 : Form
    {
        public Scenario1Draw r = new Scenario1Draw();

        public FormScenario1()
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
            Scenario1Draw scenario1Draw = new Scenario1Draw();

            panel1.Controls.Add(scenario1Draw);

            scenario1Draw.Location = new Point(this.Width / 2, 0);

            scenario1Draw.Show();

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu regresarMenu = new Menu();
            regresarMenu.Show();
            this.Close();
        }

        private void preordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Recorrido en PreOrden:\n{r.PreOrden(r.draw)}", "PreOrden", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void inordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Recorrido InOrden:\n{r.InOrden(r.draw)}", "InOrden", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Recorrido en PstOrden:\n{r.PostOrden(r.draw)}", "PostOrden", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
