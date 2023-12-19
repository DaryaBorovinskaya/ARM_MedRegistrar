using System.Diagnostics;

namespace ARM_MedRegistrar
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class RegistrationForm
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
            components = new System.ComponentModel.Container();
            labelName = new Label();
            labelLog = new Label();
            labelPassword = new Label();
            textLog = new TextBox();
            textPassword = new TextBox();
            buttRegistration = new Button();
            textPatr = new TextBox();
            textName = new TextBox();
            textSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorNoLog = new ErrorProvider(components);
            errorNoPassword = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorNoName = new ErrorProvider(components);
            label4 = new Label();
            checkViewPassword = new CheckBox();
            comboBoxPost = new ComboBox();
            label5 = new Label();
            errorNoPost = new ErrorProvider(components);
            errorMatchedLog = new ErrorProvider(components);
            errorMatchedPassword = new ErrorProvider(components);
            errorNoOneHeadDoctor = new ErrorProvider(components);
            label6 = new Label();
            errorNoPhoneNumber = new ErrorProvider(components);
            textPhoneNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorNoLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorMatchedLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorMatchedPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoOneHeadDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.Brown;
            labelName.Location = new Point(280, 33);
            labelName.Name = "labelName";
            labelName.Size = new Size(182, 32);
            labelName.TabIndex = 7;
            labelName.Text = "Регистрация";
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLog.ForeColor = Color.Firebrick;
            labelLog.Location = new Point(413, 90);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(69, 28);
            labelLog.TabIndex = 8;
            labelLog.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.Firebrick;
            labelPassword.Location = new Point(413, 215);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(81, 28);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Пароль";
            // 
            // textLog
            // 
            textLog.BackColor = Color.White;
            textLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textLog.Location = new Point(409, 130);
            textLog.Name = "textLog";
            textLog.Size = new Size(329, 34);
            textLog.TabIndex = 10;
            textLog.KeyPress += textBox_SpacePress;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.White;
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(409, 246);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(329, 34);
            textPassword.TabIndex = 11;
            textPassword.UseSystemPasswordChar = true;
            textPassword.KeyPress += textBox_SpacePress;
            // 
            // buttRegistration
            // 
            buttRegistration.BackColor = Color.FromArgb(255, 192, 192);
            buttRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttRegistration.ForeColor = Color.Firebrick;
            buttRegistration.Location = new Point(270, 548);
            buttRegistration.Name = "buttRegistration";
            buttRegistration.Size = new Size(224, 57);
            buttRegistration.TabIndex = 14;
            buttRegistration.Text = "Зарегистрироваться";
            buttRegistration.UseVisualStyleBackColor = false;
            buttRegistration.Click += buttRegistration_Click;
            // 
            // textPatr
            // 
            textPatr.BackColor = Color.White;
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(22, 350);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(329, 34);
            textPatr.TabIndex = 17;
            textPatr.KeyPress += textBox_SpacePress;
            // 
            // textName
            // 
            textName.BackColor = Color.White;
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(22, 246);
            textName.Name = "textName";
            textName.Size = new Size(329, 34);
            textName.TabIndex = 18;
            textName.KeyPress += textBox_SpacePress;
            // 
            // textSurname
            // 
            textSurname.BackColor = Color.White;
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(22, 130);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(329, 34);
            textSurname.TabIndex = 19;
            textSurname.KeyPress += textBox_SpacePress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(22, 319);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 20;
            label1.Text = "Отчество (при наличии)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(22, 215);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 21;
            label2.Text = "Имя";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(22, 99);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 22;
            label3.Text = "Фамилия";
            // 
            // errorNoLog
            // 
            errorNoLog.ContainerControl = this;
            // 
            // errorNoPassword
            // 
            errorNoPassword.ContainerControl = this;
            // 
            // errorNoSurname
            // 
            errorNoSurname.ContainerControl = this;
            // 
            // errorNoName
            // 
            errorNoName.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(409, 112);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 24;
            // 
            // checkViewPassword
            // 
            checkViewPassword.AutoSize = true;
            checkViewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkViewPassword.ForeColor = Color.Firebrick;
            checkViewPassword.Location = new Point(415, 286);
            checkViewPassword.Name = "checkViewPassword";
            checkViewPassword.Size = new Size(189, 32);
            checkViewPassword.TabIndex = 26;
            checkViewPassword.Text = "Показать пароль";
            checkViewPassword.UseVisualStyleBackColor = true;
            checkViewPassword.CheckedChanged += checkViewPassword_CheckedChanged;
            // 
            // comboBoxPost
            // 
            comboBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPost.ForeColor = Color.Firebrick;
            comboBoxPost.FormattingEnabled = true;
            comboBoxPost.Location = new Point(409, 403);
            comboBoxPost.Name = "comboBoxPost";
            comboBoxPost.Size = new Size(329, 36);
            comboBoxPost.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(415, 372);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 28;
            label5.Text = "Должность";
            // 
            // errorNoPost
            // 
            errorNoPost.ContainerControl = this;
            // 
            // errorMatchedLog
            // 
            errorMatchedLog.ContainerControl = this;
            // 
            // errorMatchedPassword
            // 
            errorMatchedPassword.ContainerControl = this;
            // 
            // errorNoOneHeadDoctor
            // 
            errorNoOneHeadDoctor.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(22, 430);
            label6.Name = "label6";
            label6.Size = new Size(166, 28);
            label6.TabIndex = 30;
            label6.Text = "Номер телефона";
            // 
            // errorNoPhoneNumber
            // 
            errorNoPhoneNumber.ContainerControl = this;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPhoneNumber.Location = new Point(22, 477);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(329, 34);
            textPhoneNumber.TabIndex = 29;
            textPhoneNumber.TextChanged += textBox1_TextChanged;
            textPhoneNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // RegistrationForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(772, 644);
            Controls.Add(label6);
            Controls.Add(textPhoneNumber);
            Controls.Add(label5);
            Controls.Add(comboBoxPost);
            Controls.Add(checkViewPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSurname);
            Controls.Add(textName);
            Controls.Add(textPatr);
            Controls.Add(buttRegistration);
            Controls.Add(textPassword);
            Controls.Add(textLog);
            Controls.Add(labelPassword);
            Controls.Add(labelLog);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += RegistrationForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorNoLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPost).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorMatchedLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorMatchedPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoOneHeadDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        #endregion

        private Label labelName;
        private Label labelLog;
        private Label labelPassword;
        private TextBox textLog;
        private TextBox textPassword;
        private Button buttRegistration;
        private TextBox textPatr;
        private TextBox textName;
        private TextBox textSurname;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorNoLog;
        private ErrorProvider errorNoPassword;
        private ErrorProvider errorNoSurname;
        private ErrorProvider errorNoName;
        private Label label4;
        private CheckBox checkViewPassword;
        private Label label5;
        private ComboBox comboBoxPost;
        private ErrorProvider errorNoPost;
        private ErrorProvider errorMatchedLog;
        private ErrorProvider errorMatchedPassword;
        private ErrorProvider errorNoOneHeadDoctor;
        private TextBox text1;
        private Label label6;
        private ErrorProvider errorNoPhoneNumber;
        private TextBox textPhoneNumber;
    }
}