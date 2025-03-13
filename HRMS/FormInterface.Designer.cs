namespace HRMS
{
    partial class FormInterface
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBoxUsername = new TextBox();
            textBoxEmail = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPosition = new TextBox();
            textBoxDepartment = new TextBox();
            textBoxSalary = new TextBox();
            textBoxJobTitle = new TextBox();
            textBoxJobDescription = new TextBox();
            buttonInput = new Button();
            comboBoxRole = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            comboBoxEmploymentStatus = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePickerCreatedAt = new DateTimePicker();
            dateTimePickerVisitDate = new DateTimePicker();
            dateTimePickerPostedAt = new DateTimePicker();
            dateTimePickerHireDate = new DateTimePicker();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(12, 45);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(229, 27);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 177);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(229, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 309);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(229, 27);
            textBoxFirstName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(12, 375);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(229, 27);
            textBoxLastName.TabIndex = 6;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(12, 441);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(229, 27);
            textBoxPosition.TabIndex = 7;
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Location = new Point(12, 507);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(229, 27);
            textBoxDepartment.TabIndex = 8;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(368, 111);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(229, 27);
            textBoxSalary.TabIndex = 10;
            // 
            // textBoxJobTitle
            // 
            textBoxJobTitle.Location = new Point(368, 243);
            textBoxJobTitle.Name = "textBoxJobTitle";
            textBoxJobTitle.Size = new Size(229, 27);
            textBoxJobTitle.TabIndex = 12;
            // 
            // textBoxJobDescription
            // 
            textBoxJobDescription.Location = new Point(368, 309);
            textBoxJobDescription.Name = "textBoxJobDescription";
            textBoxJobDescription.Size = new Size(229, 27);
            textBoxJobDescription.TabIndex = 13;
            // 
            // buttonInput
            // 
            buttonInput.Location = new Point(12, 572);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new Size(229, 29);
            buttonInput.TabIndex = 18;
            buttonInput.Text = "Внести";
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonInput_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "HR", "Employee" });
            comboBoxRole.Location = new Point(12, 110);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(229, 28);
            comboBoxRole.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 20;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(64, 31);
            label2.TabIndex = 21;
            label2.Text = "Роль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 22;
            label3.Text = "Почта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(334, 31);
            label4.TabIndex = 23;
            label4.Text = "Дата создания учетной записи";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 275);
            label5.Name = "label5";
            label5.Size = new Size(59, 31);
            label5.TabIndex = 24;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 341);
            label6.Name = "label6";
            label6.Size = new Size(109, 31);
            label6.TabIndex = 25;
            label6.Text = "Фамилия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(12, 407);
            label7.Name = "label7";
            label7.Size = new Size(130, 31);
            label7.TabIndex = 26;
            label7.Text = "Должность";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(12, 473);
            label8.Name = "label8";
            label8.Size = new Size(179, 31);
            label8.TabIndex = 27;
            label8.Text = "Подразделение";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(368, 11);
            label9.Name = "label9";
            label9.Size = new Size(258, 31);
            label9.TabIndex = 28;
            label9.Text = "Дата приема на работу";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(368, 77);
            label10.Name = "label10";
            label10.Size = new Size(200, 31);
            label10.TabIndex = 29;
            label10.Text = "Заработная плата";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(368, 143);
            label11.Name = "label11";
            label11.Size = new Size(188, 31);
            label11.TabIndex = 30;
            label11.Text = "Статус занятости";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(368, 209);
            label12.Name = "label12";
            label12.Size = new Size(217, 31);
            label12.TabIndex = 31;
            label12.Text = "Название вакансии";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(368, 275);
            label13.Name = "label13";
            label13.Size = new Size(221, 31);
            label13.TabIndex = 32;
            label13.Text = "Описание вакансии";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.Location = new Point(368, 341);
            label14.Name = "label14";
            label14.Size = new Size(297, 31);
            label14.TabIndex = 33;
            label14.Text = "Дата публикации вакансии";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label15.Location = new Point(368, 407);
            label15.Name = "label15";
            label15.Size = new Size(183, 31);
            label15.TabIndex = 34;
            label15.Text = "Статус вакансии";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label16.Location = new Point(368, 473);
            label16.Name = "label16";
            label16.Size = new Size(187, 31);
            label16.TabIndex = 35;
            label16.Text = "Дата посещения";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label17.Location = new Point(368, 539);
            label17.Name = "label17";
            label17.Size = new Size(80, 31);
            label17.TabIndex = 36;
            label17.Text = "Статус";
            // 
            // comboBoxEmploymentStatus
            // 
            comboBoxEmploymentStatus.FormattingEnabled = true;
            comboBoxEmploymentStatus.Items.AddRange(new object[] { "активен", "отпуск", "уволен" });
            comboBoxEmploymentStatus.Location = new Point(368, 176);
            comboBoxEmploymentStatus.Name = "comboBoxEmploymentStatus";
            comboBoxEmploymentStatus.Size = new Size(229, 28);
            comboBoxEmploymentStatus.TabIndex = 37;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "открыта", "закрыта" });
            comboBox1.Location = new Point(368, 440);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 28);
            comboBox1.TabIndex = 38;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "явка", "неявка", "отпуск", "болничный" });
            comboBox2.Location = new Point(368, 573);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(229, 28);
            comboBox2.TabIndex = 39;
            // 
            // dateTimePickerCreatedAt
            // 
            dateTimePickerCreatedAt.Location = new Point(12, 245);
            dateTimePickerCreatedAt.Name = "dateTimePickerCreatedAt";
            dateTimePickerCreatedAt.Size = new Size(229, 27);
            dateTimePickerCreatedAt.TabIndex = 40;
            // 
            // dateTimePickerVisitDate
            // 
            dateTimePickerVisitDate.Location = new Point(368, 509);
            dateTimePickerVisitDate.Name = "dateTimePickerVisitDate";
            dateTimePickerVisitDate.Size = new Size(229, 27);
            dateTimePickerVisitDate.TabIndex = 41;
            // 
            // dateTimePickerPostedAt
            // 
            dateTimePickerPostedAt.Location = new Point(368, 375);
            dateTimePickerPostedAt.Name = "dateTimePickerPostedAt";
            dateTimePickerPostedAt.Size = new Size(229, 27);
            dateTimePickerPostedAt.TabIndex = 42;
            // 
            // dateTimePickerHireDate
            // 
            dateTimePickerHireDate.Location = new Point(368, 47);
            dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            dateTimePickerHireDate.Size = new Size(229, 27);
            dateTimePickerHireDate.TabIndex = 43;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(12, 612);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(229, 29);
            buttonExit.TabIndex = 44;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 653);
            Controls.Add(buttonExit);
            Controls.Add(dateTimePickerHireDate);
            Controls.Add(dateTimePickerPostedAt);
            Controls.Add(dateTimePickerVisitDate);
            Controls.Add(dateTimePickerCreatedAt);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(comboBoxEmploymentStatus);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonInput);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxPosition);
            Controls.Add(textBoxDepartment);
            Controls.Add(textBoxSalary);
            Controls.Add(textBoxJobTitle);
            Controls.Add(textBoxJobDescription);
            Name = "FormInterface";
            Text = "Форма сотрудника";
            Load += FormInterface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxUsername;
        private TextBox textBoxEmail;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPosition;
        private TextBox textBoxDepartment;
        private TextBox textBoxSalary;
        private TextBox textBoxJobTitle;
        private TextBox textBoxJobDescription;
        private Button buttonInput;
        private ComboBox comboBoxRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox comboBoxEmploymentStatus;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePickerCreatedAt;
        private DateTimePicker dateTimePickerVisitDate;
        private DateTimePicker dateTimePickerPostedAt;
        private DateTimePicker dateTimePickerHireDate;
        private Button buttonExit;
    }
}