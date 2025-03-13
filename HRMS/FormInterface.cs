using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class FormInterface : Form
    {
        public FormInterface()
        {
            InitializeComponent();
        }

        private void FormInterface_Load(object sender, EventArgs e)
        {

        }

        private void buttonInput_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.FormClosed += (s, args) => this.Close();
            this.Hide();
            formMain.Show();
        }
    }
}
