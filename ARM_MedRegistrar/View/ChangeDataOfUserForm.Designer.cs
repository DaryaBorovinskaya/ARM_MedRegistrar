using System.Diagnostics;

namespace ARM_MedRegistrar
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class ChangeDataOfUserForm
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
            textOldLog = new TextBox();
            textOldPassword = new TextBox();
            buttRegistration = new Button();
            textPatr = new TextBox();
            textName = new TextBox();
            textSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorNoOldLog = new ErrorProvider(components);
            errorNoOldPassword = new ErrorProvider(components);
            errorNoChoice = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorNoName = new ErrorProvider(components);
            label4 = new Label();
            checkHeadReg = new CheckBox();
            checkBox1 = new CheckBox();
            checkViewOldPassword = new CheckBox();
            textNewLog = new TextBox();
            textNewPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            checkViewNewPassword = new CheckBox();
            errorNoNewLog = new ErrorProvider(components);
            errorNoNewPassword = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorNoOldLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoOldPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewPassword).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.Firebrick;
            labelName.Location = new Point(332, 34);
            labelName.Name = "labelName";
            labelName.Size = new Size(398, 32);
            labelName.TabIndex = 7;
            labelName.Text = "Смена данных пользователя";
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLog.ForeColor = Color.Firebrick;
            labelLog.Location = new Point(200, 397);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(140, 28);
            labelLog.TabIndex = 8;
            labelLog.Text = "Старый логин";
            labelLog.Click += labelLog_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.Firebrick;
            labelPassword.Location = new Point(190, 490);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(152, 28);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Старый пароль";
            // 
            // textOldLog
            // 
            textOldLog.BackColor = Color.White;
            textOldLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textOldLog.Location = new Point(106, 437);
            textOldLog.Name = "textOldLog";
            textOldLog.Size = new Size(329, 34);
            textOldLog.TabIndex = 10;
            // 
            // textOldPassword
            // 
            textOldPassword.BackColor = Color.White;
            textOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textOldPassword.Location = new Point(106, 534);
            textOldPassword.Name = "textOldPassword";
            textOldPassword.Size = new Size(329, 34);
            textOldPassword.TabIndex = 11;
            textOldPassword.UseSystemPasswordChar = true;
            // 
            // buttRegistration
            // 
            buttRegistration.BackColor = Color.FromArgb(255, 192, 192);
            buttRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttRegistration.ForeColor = Color.Firebrick;
            buttRegistration.Location = new Point(428, 701);
            buttRegistration.Name = "buttRegistration";
            buttRegistration.Size = new Size(224, 57);
            buttRegistration.TabIndex = 14;
            buttRegistration.Text = "Обновить данные";
            buttRegistration.UseVisualStyleBackColor = false;
            buttRegistration.Click += buttRegistration_Click;
            // 
            // textPatr
            // 
            textPatr.BackColor = Color.White;
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(354, 329);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(329, 34);
            textPatr.TabIndex = 17;
            // 
            // textName
            // 
            textName.BackColor = Color.White;
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(354, 239);
            textName.Name = "textName";
            textName.Size = new Size(329, 34);
            textName.TabIndex = 18;
            // 
            // textSurname
            // 
            textSurname.BackColor = Color.White;
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(354, 143);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(329, 34);
            textSurname.TabIndex = 19;
            textSurname.TextChanged += textSurname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(409, 288);
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
            label2.Location = new Point(498, 198);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 21;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(477, 101);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 22;
            label3.Text = "Фамилия";
            // 
            // errorNoOldLog
            // 
            errorNoOldLog.ContainerControl = this;
            // 
            // errorNoOldPassword
            // 
            errorNoOldPassword.ContainerControl = this;
            // 
            // errorNoChoice
            // 
            errorNoChoice.ContainerControl = this;
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
            label4.Click += label4_Click;
            // 
            // checkHeadReg
            // 
            checkHeadReg.AutoSize = true;
            checkHeadReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkHeadReg.ForeColor = Color.Firebrick;
            checkHeadReg.Location = new Point(367, 645);
            checkHeadReg.Name = "checkHeadReg";
            checkHeadReg.Size = new Size(345, 32);
            checkHeadReg.TabIndex = 25;
            checkHeadReg.Text = "Я - заведующий регистратурой";
            checkHeadReg.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 24);
            checkBox1.TabIndex = 0;
            // 
            // checkViewOldPassword
            // 
            checkViewOldPassword.AutoSize = true;
            checkViewOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkViewOldPassword.ForeColor = Color.Firebrick;
            checkViewOldPassword.Location = new Point(190, 583);
            checkViewOldPassword.Name = "checkViewOldPassword";
            checkViewOldPassword.Size = new Size(189, 32);
            checkViewOldPassword.TabIndex = 26;
            checkViewOldPassword.Text = "Показать пароль";
            checkViewOldPassword.UseVisualStyleBackColor = true;
            checkViewOldPassword.CheckedChanged += checkViewOldPassword_CheckedChanged_1;
            // 
            // textNewLog
            // 
            textNewLog.BackColor = Color.White;
            textNewLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNewLog.Location = new Point(676, 437);
            textNewLog.Name = "textNewLog";
            textNewLog.Size = new Size(329, 34);
            textNewLog.TabIndex = 27;
            // 
            // textNewPassword
            // 
            textNewPassword.BackColor = Color.White;
            textNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNewPassword.Location = new Point(676, 534);
            textNewPassword.Name = "textNewPassword";
            textNewPassword.Size = new Size(329, 34);
            textNewPassword.TabIndex = 28;
            textNewPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(770, 397);
            label5.Name = "label5";
            label5.Size = new Size(135, 28);
            label5.TabIndex = 29;
            label5.Text = "Новый логин";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(770, 490);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 30;
            label6.Text = "Новый пароль";
            // 
            // checkViewNewPassword
            // 
            checkViewNewPassword.AutoSize = true;
            checkViewNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkViewNewPassword.ForeColor = Color.Firebrick;
            checkViewNewPassword.Location = new Point(745, 583);
            checkViewNewPassword.Name = "checkViewNewPassword";
            checkViewNewPassword.Size = new Size(189, 32);
            checkViewNewPassword.TabIndex = 31;
            checkViewNewPassword.Text = "Показать пароль";
            checkViewNewPassword.UseVisualStyleBackColor = true;
            checkViewNewPassword.CheckedChanged += checkViewNewPassword_CheckedChanged;
            // 
            // errorNoNewLog
            // 
            errorNoNewLog.ContainerControl = this;
            // 
            // errorNoNewPassword
            // 
            errorNoNewPassword.ContainerControl = this;
            // 
            // ChangeDataOfUser
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1051, 780);
            Controls.Add(checkViewNewPassword);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textNewPassword);
            Controls.Add(textNewLog);
            Controls.Add(checkViewOldPassword);
            Controls.Add(checkBox1);
            Controls.Add(checkHeadReg);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSurname);
            Controls.Add(textName);
            Controls.Add(textPatr);
            Controls.Add(buttRegistration);
            Controls.Add(textOldPassword);
            Controls.Add(textOldLog);
            Controls.Add(labelPassword);
            Controls.Add(labelLog);
            Controls.Add(labelName);
            Name = "ChangeDataOfUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load_1;
            ((System.ComponentModel.ISupportInitialize)errorNoOldLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoOldPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewPassword).EndInit();
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
        private TextBox textOldLog;
        private TextBox textOldPassword;
        private Button buttRegistration;
        private TextBox textPatr;
        private TextBox textName;
        private TextBox textSurname;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorNoOldLog;
        private ErrorProvider errorNoOldPassword;
        private ErrorProvider errorNoChoice;
        private ErrorProvider errorNoSurname;
        private ErrorProvider errorNoName;
        private Label label4;
        private CheckBox checkHeadReg;
        private CheckBox checkBox1;
        private CheckBox checkViewOldPassword;
        private Label label5;
        private TextBox textNewPassword;
        private TextBox textNewLog;
        private CheckBox checkViewNewPassword;
        private Label label6;
        private ErrorProvider errorNoNewLog;
        private ErrorProvider errorNoNewPassword;
    }
}