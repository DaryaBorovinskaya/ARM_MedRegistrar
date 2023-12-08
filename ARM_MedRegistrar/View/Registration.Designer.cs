using System.Diagnostics;

namespace ARM_MedRegistrar
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class Registration
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
            errorNoChoice = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorNoName = new ErrorProvider(components);
            label4 = new Label();
            checkHeadReg = new CheckBox();
            checkBox1 = new CheckBox();
            checkViewPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorNoLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.Brown;
            labelName.Location = new Point(409, 32);
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
            labelLog.Location = new Point(454, 385);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(69, 28);
            labelLog.TabIndex = 8;
            labelLog.Text = "Логин";
            labelLog.Click += labelLog_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.Firebrick;
            labelPassword.Location = new Point(454, 483);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(81, 28);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Пароль";
            // 
            // textLog
            // 
            textLog.BackColor = Color.White;
            textLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textLog.Location = new Point(327, 430);
            textLog.Name = "textLog";
            textLog.Size = new Size(329, 34);
            textLog.TabIndex = 10;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.White;
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(327, 525);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(329, 34);
            textPassword.TabIndex = 11;
            textPassword.UseSystemPasswordChar = true;
            // 
            // buttRegistration
            // 
            buttRegistration.BackColor = Color.FromArgb(255, 192, 192);
            buttRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttRegistration.ForeColor = Color.Firebrick;
            buttRegistration.Location = new Point(380, 672);
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
            textPatr.Location = new Point(327, 333);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(329, 34);
            textPatr.TabIndex = 17;
            // 
            // textName
            // 
            textName.BackColor = Color.White;
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(327, 239);
            textName.Name = "textName";
            textName.Size = new Size(329, 34);
            textName.TabIndex = 18;
            // 
            // textSurname
            // 
            textSurname.BackColor = Color.White;
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(327, 143);
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
            label1.Location = new Point(393, 289);
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
            label2.Location = new Point(466, 191);
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
            label3.Location = new Point(454, 91);
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
            checkHeadReg.Location = new Point(327, 596);
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
            // checkViewPassword
            // 
            checkViewPassword.AutoSize = true;
            checkViewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkViewPassword.ForeColor = Color.Firebrick;
            checkViewPassword.Location = new Point(675, 525);
            checkViewPassword.Name = "checkViewPassword";
            checkViewPassword.Size = new Size(189, 32);
            checkViewPassword.TabIndex = 26;
            checkViewPassword.Text = "Показать пароль";
            checkViewPassword.UseVisualStyleBackColor = true;
            checkViewPassword.CheckedChanged += checkViewPassword_CheckedChanged;
            // 
            // Registration
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1051, 780);
            Controls.Add(checkViewPassword);
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
            Controls.Add(textPassword);
            Controls.Add(textLog);
            Controls.Add(labelPassword);
            Controls.Add(labelLog);
            Controls.Add(labelName);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load_1;
            ((System.ComponentModel.ISupportInitialize)errorNoLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
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
        private ErrorProvider errorNoChoice;
        private ErrorProvider errorNoSurname;
        private ErrorProvider errorNoName;
        private Label label4;
        private CheckBox checkHeadReg;
        private CheckBox checkBox1;
        private CheckBox checkViewPassword;
    }
}