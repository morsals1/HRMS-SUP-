namespace HRMS
{
    partial class FormEntrance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEntrance = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonEntrance
            // 
            buttonEntrance.Location = new Point(215, 204);
            buttonEntrance.Name = "buttonEntrance";
            buttonEntrance.Size = new Size(150, 27);
            buttonEntrance.TabIndex = 0;
            buttonEntrance.Text = "Вход";
            buttonEntrance.UseVisualStyleBackColor = true;
            buttonEntrance.Click += buttonEntrance_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin = new PHTextBox("Логин");
            textBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.Location = new Point(162, 109);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(249, 27);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword = new PHTextBox("Пароль");
            textBoxPassword.Location = new Point(162, 158);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(249, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // FormEntrance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(582, 353);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonEntrance);
            Name = "FormEntrance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrance;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
    }
}