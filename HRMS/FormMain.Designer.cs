namespace HRMS
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            buttonMyMessages = new Button();
            buttonMyNotifications = new Button();
            buttonMyRequests = new Button();
            buttonMyUsers = new Button();
            labelMenu = new Label();
            buttonMyProfile = new Button();
            panelMain = new Panel();
            panelRender = new Panel();
            menuStrip = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            projectsToolStripMenuItem = new ToolStripMenuItem();
            documentsToolStripMenuItem = new ToolStripMenuItem();
            communicationToolStripMenuItem = new ToolStripMenuItem();
            helpDeskToolStripMenuItem = new ToolStripMenuItem();
            textBoxFind = new TextBox();
            labelAppName = new Label();
            UserIcon = new PictureBox();
            labelUserName = new Label();
            labelUserStatus = new Label();
            panelMenu.SuspendLayout();
            panelMain.SuspendLayout();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserIcon).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDarkDark;
            panelMenu.Controls.Add(buttonMyMessages);
            panelMenu.Controls.Add(buttonMyNotifications);
            panelMenu.Controls.Add(buttonMyRequests);
            panelMenu.Controls.Add(buttonMyUsers);
            panelMenu.Controls.Add(labelMenu);
            panelMenu.Controls.Add(buttonMyProfile);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 28);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 776);
            panelMenu.TabIndex = 0;
            // 
            // buttonMyMessages
            // 
            buttonMyMessages.BackColor = SystemColors.ControlDarkDark;
            buttonMyMessages.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            buttonMyMessages.FlatAppearance.BorderSize = 0;
            buttonMyMessages.FlatStyle = FlatStyle.Flat;
            buttonMyMessages.ForeColor = SystemColors.Control;
            buttonMyMessages.Location = new Point(-3, 223);
            buttonMyMessages.Name = "buttonMyMessages";
            buttonMyMessages.Size = new Size(200, 29);
            buttonMyMessages.TabIndex = 10;
            buttonMyMessages.Text = "Мои сообщения";
            buttonMyMessages.TextAlign = ContentAlignment.MiddleLeft;
            buttonMyMessages.UseVisualStyleBackColor = false;
            buttonMyMessages.Click += buttonMyMessages_Click;
            // 
            // buttonMyNotifications
            // 
            buttonMyNotifications.BackColor = SystemColors.ControlDarkDark;
            buttonMyNotifications.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            buttonMyNotifications.FlatAppearance.BorderSize = 0;
            buttonMyNotifications.FlatStyle = FlatStyle.Flat;
            buttonMyNotifications.ForeColor = SystemColors.Control;
            buttonMyNotifications.Location = new Point(-3, 188);
            buttonMyNotifications.Name = "buttonMyNotifications";
            buttonMyNotifications.Size = new Size(200, 29);
            buttonMyNotifications.TabIndex = 8;
            buttonMyNotifications.Text = "Мои уведомления";
            buttonMyNotifications.TextAlign = ContentAlignment.MiddleLeft;
            buttonMyNotifications.UseVisualStyleBackColor = false;
            buttonMyNotifications.Click += buttonMyNotifications_Click;
            // 
            // buttonMyRequests
            // 
            buttonMyRequests.BackColor = SystemColors.ControlDarkDark;
            buttonMyRequests.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            buttonMyRequests.FlatAppearance.BorderSize = 0;
            buttonMyRequests.FlatStyle = FlatStyle.Flat;
            buttonMyRequests.ForeColor = SystemColors.Control;
            buttonMyRequests.Location = new Point(-3, 153);
            buttonMyRequests.Name = "buttonMyRequests";
            buttonMyRequests.Size = new Size(200, 29);
            buttonMyRequests.TabIndex = 7;
            buttonMyRequests.Text = "Мои заявки";
            buttonMyRequests.TextAlign = ContentAlignment.MiddleLeft;
            buttonMyRequests.UseVisualStyleBackColor = false;
            buttonMyRequests.Click += buttonMyRequests_Click;
            // 
            // buttonMyUsers
            // 
            buttonMyUsers.BackColor = SystemColors.ControlDarkDark;
            buttonMyUsers.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            buttonMyUsers.FlatAppearance.BorderSize = 0;
            buttonMyUsers.FlatStyle = FlatStyle.Flat;
            buttonMyUsers.ForeColor = SystemColors.Control;
            buttonMyUsers.Location = new Point(-3, 118);
            buttonMyUsers.Name = "buttonMyUsers";
            buttonMyUsers.Size = new Size(200, 29);
            buttonMyUsers.TabIndex = 6;
            buttonMyUsers.Text = "Мои сотрудники";
            buttonMyUsers.TextAlign = ContentAlignment.MiddleLeft;
            buttonMyUsers.UseVisualStyleBackColor = false;
            buttonMyUsers.Click += buttonMyUsers_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMenu.ForeColor = SystemColors.Control;
            labelMenu.Location = new Point(3, 9);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(79, 31);
            labelMenu.TabIndex = 5;
            labelMenu.Text = "Меню";
            // 
            // buttonMyProfile
            // 
            buttonMyProfile.BackColor = SystemColors.ControlDarkDark;
            buttonMyProfile.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            buttonMyProfile.FlatAppearance.BorderSize = 0;
            buttonMyProfile.FlatStyle = FlatStyle.Flat;
            buttonMyProfile.ForeColor = SystemColors.Control;
            buttonMyProfile.Location = new Point(-3, 83);
            buttonMyProfile.Name = "buttonMyProfile";
            buttonMyProfile.Size = new Size(200, 29);
            buttonMyProfile.TabIndex = 1;
            buttonMyProfile.Text = "Мой профиль";
            buttonMyProfile.TextAlign = ContentAlignment.MiddleLeft;
            buttonMyProfile.UseVisualStyleBackColor = false;
            buttonMyProfile.Click += buttonMyProfile_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.ControlLightLight;
            panelMain.Controls.Add(panelRender);
            panelMain.Controls.Add(panelMenu);
            panelMain.Controls.Add(menuStrip);
            panelMain.Dock = DockStyle.Bottom;
            panelMain.Location = new Point(0, 49);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1182, 804);
            panelMain.TabIndex = 2;
            // 
            // panelRender
            // 
            panelRender.Dock = DockStyle.Right;
            panelRender.Location = new Point(203, 28);
            panelRender.Name = "panelRender";
            panelRender.Size = new Size(979, 776);
            panelRender.TabIndex = 2;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ControlDark;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, usersToolStripMenuItem, projectsToolStripMenuItem, documentsToolStripMenuItem, communicationToolStripMenuItem, helpDeskToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1182, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.ForeColor = SystemColors.Control;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(79, 24);
            homeToolStripMenuItem.Text = "Главная";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.ForeColor = SystemColors.Control;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(105, 24);
            usersToolStripMenuItem.Text = "Сотрудники";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // projectsToolStripMenuItem
            // 
            projectsToolStripMenuItem.ForeColor = SystemColors.Control;
            projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            projectsToolStripMenuItem.Size = new Size(84, 24);
            projectsToolStripMenuItem.Text = "Проекты";
            projectsToolStripMenuItem.Click += projectsToolStripMenuItem_Click;
            // 
            // documentsToolStripMenuItem
            // 
            documentsToolStripMenuItem.ForeColor = SystemColors.Control;
            documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            documentsToolStripMenuItem.Size = new Size(101, 24);
            documentsToolStripMenuItem.Text = "Документы";
            documentsToolStripMenuItem.Click += documentsToolStripMenuItem_Click;
            // 
            // communicationToolStripMenuItem
            // 
            communicationToolStripMenuItem.ForeColor = SystemColors.Control;
            communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            communicationToolStripMenuItem.Size = new Size(89, 24);
            communicationToolStripMenuItem.Text = "Общение";
            communicationToolStripMenuItem.Click += communicationToolStripMenuItem_Click;
            // 
            // helpDeskToolStripMenuItem
            // 
            helpDeskToolStripMenuItem.ForeColor = SystemColors.Control;
            helpDeskToolStripMenuItem.Name = "helpDeskToolStripMenuItem";
            helpDeskToolStripMenuItem.Size = new Size(91, 24);
            helpDeskToolStripMenuItem.Text = "Help Desk";
            helpDeskToolStripMenuItem.Click += helpDeskToolStripMenuItem_Click;
            // 
            // textBoxFind
            // 
            textBoxFind = new PHTextBox("Поиск");
            textBoxFind.BackColor = SystemColors.GradientActiveCaption;
            textBoxFind.BorderStyle = BorderStyle.FixedSingle;
            textBoxFind.ForeColor = SystemColors.ActiveCaptionText;
            textBoxFind.Location = new Point(110, 13);
            textBoxFind.Margin = new Padding(5);
            textBoxFind.Name = "textBoxFind";
            textBoxFind.Size = new Size(181, 27);
            textBoxFind.TabIndex = 3;
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAppName.ForeColor = SystemColors.ActiveCaptionText;
            labelAppName.Location = new Point(0, 2);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(74, 38);
            labelAppName.TabIndex = 4;
            labelAppName.Text = "Polis";
            // 
            // UserIcon
            // 
            UserIcon.Image = Properties.Resources.user;
            UserIcon.InitialImage = Properties.Resources.user;
            UserIcon.Location = new Point(761, 2);
            UserIcon.Name = "UserIcon";
            UserIcon.Size = new Size(90, 44);
            UserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            UserIcon.TabIndex = 5;
            UserIcon.TabStop = false;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUserName.Location = new Point(857, 2);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(247, 23);
            labelUserName.TabIndex = 6;
            labelUserName.Text = "Меньшиков Артур Андреевич";
            // 
            // labelUserStatus
            // 
            labelUserStatus.AutoSize = true;
            labelUserStatus.Location = new Point(857, 26);
            labelUserStatus.Name = "labelUserStatus";
            labelUserStatus.Size = new Size(82, 20);
            labelUserStatus.TabIndex = 7;
            labelUserStatus.Text = "Сотрудник";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1182, 853);
            Controls.Add(labelUserStatus);
            Controls.Add(labelUserName);
            Controls.Add(UserIcon);
            Controls.Add(labelAppName);
            Controls.Add(textBoxFind);
            Controls.Add(panelMain);
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button buttonMyProfile;
        private Label labelMenu;
        private Button buttonMyUsers;
        private Button buttonMyRequests;
        private Button buttonMyNotifications;
        private Button buttonMyMessages;
        private Panel panelMain;
        private TextBox textBoxFind;
        private Label labelAppName;
        private PictureBox UserIcon;
        private Label labelUserName;
        private Label labelUserStatus;
        private MenuStrip menuStrip;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem projectsToolStripMenuItem;
        private ToolStripMenuItem documentsToolStripMenuItem;
        private ToolStripMenuItem communicationToolStripMenuItem;
        private ToolStripMenuItem helpDeskToolStripMenuItem;
        private Panel panelRender;
    }
}
