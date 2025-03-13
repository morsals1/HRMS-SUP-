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

            // Создаём DataGridView
            DataGridView dataGridView = new DataGridView
            {
                Name = "dataGridViewUsers",
                Size = new Size(panelRender.Width - 20, panelRender.Height - 60),
                Location = new Point(10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Добавляем столбцы
            dataGridView.Columns.Add("UserID", "ID");
            dataGridView.Columns.Add("Username", "Логин");
            dataGridView.Columns.Add("Role", "Роль");
            dataGridView.Columns.Add("Email", "E-mail");
            dataGridView.Columns.Add("FirstName", "Имя");
            dataGridView.Columns.Add("LastName", "Фамилия");
            dataGridView.Columns.Add("Position", "Должность");
            dataGridView.Columns.Add("Department", "Отдел");
            dataGridView.Columns.Add("HireDate", "Дата приёма");
            dataGridView.Columns.Add("Salary", "Зарплата");
            dataGridView.Columns.Add("Status", "Статус");

            // Добавляем тестовые данные (можно заменить на загрузку из БД)
            dataGridView.Rows.Add(1, "ivanov", "Admin", "ivanov@mail.com", "Иван", "Иванов", "HR", "Кадры", "2022-05-10", "50000", "Активен");
            dataGridView.Rows.Add(2, "petrov", "Employee", "petrov@mail.com", "Пётр", "Петров", "Разработчик", "ИТ", "2023-01-15", "60000", "В отпуске");

            // Создаём кнопку "Добавить сотрудника"
            Button addButton = new Button
            {
                Name = "btnAddEmployee",
                Text = "Добавить сотрудника",
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
