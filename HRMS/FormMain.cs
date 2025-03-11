namespace HRMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();

            // Создаем PictureBox
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile("user.png")
            };

            // Создаем Label1 (ФИО)
            Label labelFIO = new Label
            {
                Text = labelUserName.Text,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(120, 20),
                AutoSize = true
            };

            // Создаем Label2 (Роль)
            Label labelRole = new Label
            {
                Text = labelUserStatus.Text,
                Font = new Font("Arial", 10),
                ForeColor = Color.Blue,
                Location = new Point(120, 50),
                AutoSize = true
            };

            // Создаем Label3 (Должность)
            Label labelPosition = new Label
            {
                Text = "Разработчик",
                Font = new Font("Arial", 10),
                Location = new Point(120, 80),
                AutoSize = true
            };

            // Добавляем элементы в panelRender
            panelRender.Controls.Add(pictureBox);
            panelRender.Controls.Add(labelFIO);
            panelRender.Controls.Add(labelRole);
            panelRender.Controls.Add(labelPosition);
        }


        private void buttonMyUsers_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }

        private void buttonMyRequests_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }

        private void buttonMyNotifications_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }

        private void buttonMyMessages_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }

        private void helpDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }

        private void communicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelRender.Controls.Clear();
        }
    }
}
