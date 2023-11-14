using BinaryTrees.Properties;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Icon = Resources.Tree;
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000;

            label4.Text = DateTime.Now.ToString("F");
        }

        private void btnSendPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                btnSendPassword.Enabled = false;
                MessageBox.Show("Por favor escribir una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSendPassword.Enabled = true;
            }
            else
            {
                if (txtPassword.Text == "123" || txtPassword.Text == "unad")
                {
                    // Ir a nuevo form
                    var dataForm = new Menu();
                    dataForm.Show();
                    Hide();
                }
                else
                {
                    btnSendPassword.Enabled = false;
                    MessageBox.Show("Ingrese una contraseña correcta...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnSendPassword.Enabled = true;
                    txtPassword.Clear();
                }
            }
            txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendPassword.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
