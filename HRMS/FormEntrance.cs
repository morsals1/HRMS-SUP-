using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRMS
{
    public partial class FormEntrance : Form
    {
        public FormEntrance()
        {
            InitializeComponent();

            textBoxLogin.Left = (this.ClientSize.Width - textBoxLogin.Width) / 2;
            textBoxLogin.Top = (this.ClientSize.Height - textBoxLogin.Height - 150) / 2;

            textBoxPassword.Left = (this.ClientSize.Width - textBoxPassword.Width) / 2;
            textBoxPassword.Top = (this.ClientSize.Height - textBoxPassword.Height - 50) / 2;

            buttonEntrance.Left = (this.ClientSize.Width - buttonEntrance.Width) / 2;
            buttonEntrance.Top = (this.ClientSize.Height - buttonEntrance.Height + 50) / 2;
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text) 
                && textBoxLogin.Text != "Логин" && textBoxPassword.Text != "Пароль")
            {
                FormMain formMain = new FormMain();
                formMain.FormClosed += (s, args) => this.Close();
                this.Hide();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
