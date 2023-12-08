﻿namespace ARM_MedRegistrar;

partial class Entrance
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
        buttEntrance = new Button();
        textLog = new TextBox();
        textPassword = new TextBox();
        labelLog = new Label();
        labelPassword = new Label();
        buttonRegistration = new Button();
        labelName = new Label();
        errorNoLog = new ErrorProvider(components);
        errorNoPassword = new ErrorProvider(components);
        checkViewPassword = new CheckBox();
        ((System.ComponentModel.ISupportInitialize)errorNoLog).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPassword).BeginInit();
        SuspendLayout();
        // 
        // buttEntrance
        // 
        buttEntrance.BackColor = Color.FromArgb(255, 192, 192);
        buttEntrance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        buttEntrance.ForeColor = Color.Firebrick;
        buttEntrance.Location = new Point(312, 328);
        buttEntrance.Name = "buttEntrance";
        buttEntrance.Size = new Size(177, 65);
        buttEntrance.TabIndex = 0;
        buttEntrance.Text = "Войти";
        buttEntrance.UseVisualStyleBackColor = false;
        buttEntrance.Click += buttEntrance_Click;
        // 
        // textLog
        // 
        textLog.BackColor = Color.Snow;
        textLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textLog.Location = new Point(239, 174);
        textLog.Name = "textLog";
        textLog.Size = new Size(329, 34);
        textLog.TabIndex = 1;
        // 
        // textPassword
        // 
        textPassword.BackColor = Color.Snow;
        textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPassword.Location = new Point(239, 263);
        textPassword.Name = "textPassword";
        textPassword.Size = new Size(329, 34);
        textPassword.TabIndex = 2;
        textPassword.UseSystemPasswordChar = true;
        // 
        // labelLog
        // 
        labelLog.AutoSize = true;
        labelLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        labelLog.ForeColor = Color.Firebrick;
        labelLog.Location = new Point(357, 122);
        labelLog.Name = "labelLog";
        labelLog.Size = new Size(69, 28);
        labelLog.TabIndex = 3;
        labelLog.Text = "Логин";
        // 
        // labelPassword
        // 
        labelPassword.AutoSize = true;
        labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        labelPassword.ForeColor = Color.Firebrick;
        labelPassword.Location = new Point(357, 220);
        labelPassword.Name = "labelPassword";
        labelPassword.Size = new Size(81, 28);
        labelPassword.TabIndex = 4;
        labelPassword.Text = "Пароль";
        // 
        // buttonRegistration
        // 
        buttonRegistration.Font = new Font("Trebuchet MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
        buttonRegistration.ForeColor = Color.Black;
        buttonRegistration.Location = new Point(283, 413);
        buttonRegistration.Name = "buttonRegistration";
        buttonRegistration.Size = new Size(229, 34);
        buttonRegistration.TabIndex = 5;
        buttonRegistration.Text = "Зарегистрироваться";
        buttonRegistration.UseVisualStyleBackColor = true;
        buttonRegistration.Click += buttonRegistration_Click;
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
        labelName.ForeColor = Color.Brown;
        labelName.Location = new Point(255, 46);
        labelName.Name = "labelName";
        labelName.Size = new Size(313, 32);
        labelName.TabIndex = 6;
        labelName.Text = "АРМ медрегистратора";
        // 
        // errorNoLog
        // 
        errorNoLog.ContainerControl = this;
        // 
        // errorNoPassword
        // 
        errorNoPassword.ContainerControl = this;
        // 
        // checkViewPassword
        // 
        checkViewPassword.AutoSize = true;
        checkViewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        checkViewPassword.ForeColor = Color.Firebrick;
        checkViewPassword.Location = new Point(607, 263);
        checkViewPassword.Name = "checkViewPassword";
        checkViewPassword.Size = new Size(189, 32);
        checkViewPassword.TabIndex = 7;
        checkViewPassword.Text = "Показать пароль";
        checkViewPassword.UseVisualStyleBackColor = true;
        checkViewPassword.CheckedChanged += checkViewPassword_CheckedChanged;
        // 
        // Entrance
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(803, 491);
        Controls.Add(checkViewPassword);
        Controls.Add(labelName);
        Controls.Add(buttonRegistration);
        Controls.Add(labelPassword);
        Controls.Add(labelLog);
        Controls.Add(textPassword);
        Controls.Add(textLog);
        Controls.Add(buttEntrance);
        Name = "Entrance";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Entrance";
        Load += Entrance_Load;
        ((System.ComponentModel.ISupportInitialize)errorNoLog).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPassword).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttEntrance;
    private TextBox textLog;
    private TextBox textPassword;
    private Label labelLog;
    private Label labelPassword;
    private Button buttonRegistration;
    private Label labelName;
    private ErrorProvider errorNoLog;
    private ErrorProvider errorNoPassword;
    private CheckBox checkViewPassword;
}