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

            // ������� PictureBox
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile("user.png")
            };

            // ������� Label1 (���)
            Label labelFIO = new Label
            {
                Text = labelUserName.Text,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(120, 20),
                AutoSize = true
            };

            // ������� Label2 (����)
            Label labelRole = new Label
            {
                Text = labelUserStatus.Text,
                Font = new Font("Arial", 10),
                ForeColor = Color.Blue,
                Location = new Point(120, 50),
                AutoSize = true
            };

            // ������� Label3 (���������)
            Label labelPosition = new Label
            {
                Text = "�����������",
                Font = new Font("Arial", 10),
                Location = new Point(120, 80),
                AutoSize = true
            };

            // ��������� �������� � panelRender
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

            // ������ DataGridView
            DataGridView dataGridView = new DataGridView
            {
                Name = "dataGridViewUsers",
                Size = new Size(panelRender.Width - 20, panelRender.Height - 60),
                Location = new Point(10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // ��������� �������
            dataGridView.Columns.Add("UserID", "ID");
            dataGridView.Columns.Add("Username", "�����");
            dataGridView.Columns.Add("Role", "����");
            dataGridView.Columns.Add("Email", "E-mail");
            dataGridView.Columns.Add("FirstName", "���");
            dataGridView.Columns.Add("LastName", "�������");
            dataGridView.Columns.Add("Position", "���������");
            dataGridView.Columns.Add("Department", "�����");
            dataGridView.Columns.Add("HireDate", "���� �����");
            dataGridView.Columns.Add("Salary", "��������");
            dataGridView.Columns.Add("Status", "������");

            // ��������� �������� ������ (����� �������� �� �������� �� ��)
            dataGridView.Rows.Add(1, "ivanov", "Admin", "ivanov@mail.com", "����", "������", "HR", "�����", "2022-05-10", "50000", "�������");
            dataGridView.Rows.Add(2, "petrov", "Employee", "petrov@mail.com", "ϸ��", "������", "�����������", "��", "2023-01-15", "60000", "� �������");

            // ������ ������ "�������� ����������"
            Button addButton = new Button
            {
                Name = "btnAddEmployee",
                Text = "�������� ����������",
                Size = new Size(200, 30),
                Location = new Point(10, panelRender.Height - 40)
            };

            addButton.Click += (s, ev) =>
            {
                FormInterface formInterface = new FormInterface();
                formInterface.FormClosed += (s, args) => this.Close();
                this.Hide();
                formInterface.Show();
            };

            panelRender.Controls.Add(dataGridView);
            panelRender.Controls.Add(addButton);
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
