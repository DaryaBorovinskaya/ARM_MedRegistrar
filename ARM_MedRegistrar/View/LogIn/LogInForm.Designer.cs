namespace ARM_MedRegistrar;

partial class LogInForm
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
        buttLogIn = new Button();
        textLog = new TextBox();
        textPassword = new TextBox();
        labelLog = new Label();
        labelPassword = new Label();
        buttonRegistration = new Button();
        labelName = new Label();
        errorNoLog = new ErrorProvider(components);
        errorNoPassword = new ErrorProvider(components);
        checkViewPassword = new CheckBox();
        buttChangeDataOfUser = new Button();
        errorWrongLogOrPassword = new ErrorProvider(components);
        errorWrongPassword = new ErrorProvider(components);
        labelWrongLogOrPassword = new Label();
        ((System.ComponentModel.ISupportInitialize)errorNoLog).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPassword).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorWrongLogOrPassword).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorWrongPassword).BeginInit();
        SuspendLayout();
        // 
        // buttLogIn
        // 
        buttLogIn.BackColor = Color.FromArgb(255, 192, 192);
        buttLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        buttLogIn.ForeColor = Color.Firebrick;
        buttLogIn.Location = new Point(313, 327);
        buttLogIn.Name = "buttLogIn";
        buttLogIn.Size = new Size(177, 65);
        buttLogIn.TabIndex = 0;
        buttLogIn.Text = "Войти";
        buttLogIn.UseVisualStyleBackColor = false;
        buttLogIn.Click += buttLogIn_Click;
        // 
        // textLog
        // 
        textLog.BackColor = Color.Snow;
        textLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textLog.Location = new Point(239, 170);
        textLog.Name = "textLog";
        textLog.Size = new Size(329, 34);
        textLog.TabIndex = 1;
        textLog.KeyPress += TextBox_SpacePress;
        // 
        // textPassword
        // 
        textPassword.BackColor = Color.Snow;
        textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPassword.Location = new Point(239, 264);
        textPassword.Name = "textPassword";
        textPassword.Size = new Size(329, 34);
        textPassword.TabIndex = 2;
        textPassword.UseSystemPasswordChar = true;
        textPassword.KeyPress += TextBox_SpacePress;
        // 
        // labelLog
        // 
        labelLog.AutoSize = true;
        labelLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        labelLog.ForeColor = Color.Firebrick;
        labelLog.Location = new Point(357, 125);
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
        buttonRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
        buttonRegistration.ForeColor = Color.Black;
        buttonRegistration.Location = new Point(113, 450);
        buttonRegistration.Name = "buttonRegistration";
        buttonRegistration.Size = new Size(238, 38);
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
        labelName.Location = new Point(255, 51);
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
        checkViewPassword.Location = new Point(588, 264);
        checkViewPassword.Name = "checkViewPassword";
        checkViewPassword.Size = new Size(189, 32);
        checkViewPassword.TabIndex = 7;
        checkViewPassword.Text = "Показать пароль";
        checkViewPassword.UseVisualStyleBackColor = true;
        checkViewPassword.CheckedChanged += checkViewPassword_CheckedChanged;
        // 
        // buttChangeDataOfUser
        // 
        buttChangeDataOfUser.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
        buttChangeDataOfUser.ForeColor = Color.Black;
        buttChangeDataOfUser.Location = new Point(464, 450);
        buttChangeDataOfUser.Name = "buttChangeDataOfUser";
        buttChangeDataOfUser.Size = new Size(238, 38);
        buttChangeDataOfUser.TabIndex = 8;
        buttChangeDataOfUser.Text = "Сменить данные";
        buttChangeDataOfUser.UseVisualStyleBackColor = true;
        buttChangeDataOfUser.Click += buttChangeDataOfUser_Click;
        // 
        // errorWrongLogOrPassword
        // 
        errorWrongLogOrPassword.ContainerControl = this;
        // 
        // errorWrongPassword
        // 
        errorWrongPassword.ContainerControl = this;
        // 
        // labelWrongLogOrPassword
        // 
        labelWrongLogOrPassword.AutoSize = true;
        labelWrongLogOrPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        labelWrongLogOrPassword.ForeColor = Color.Red;
        labelWrongLogOrPassword.Location = new Point(268, 408);
        labelWrongLogOrPassword.Name = "labelWrongLogOrPassword";
        labelWrongLogOrPassword.Size = new Size(279, 28);
        labelWrongLogOrPassword.TabIndex = 9;
        labelWrongLogOrPassword.Text = "Неверный логин или пароль";
        labelWrongLogOrPassword.Visible = false;
        // 
        // LogInForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(830, 523);
        Controls.Add(labelWrongLogOrPassword);
        Controls.Add(buttChangeDataOfUser);
        Controls.Add(checkViewPassword);
        Controls.Add(labelName);
        Controls.Add(buttonRegistration);
        Controls.Add(labelPassword);
        Controls.Add(labelLog);
        Controls.Add(textPassword);
        Controls.Add(textLog);
        Controls.Add(buttLogIn);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "LogInForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Entrance";
        ((System.ComponentModel.ISupportInitialize)errorNoLog).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPassword).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorWrongLogOrPassword).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorWrongPassword).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttLogIn;
    private TextBox textLog;
    private TextBox textPassword;
    private Label labelLog;
    private Label labelPassword;
    private Button buttonRegistration;
    private Label labelName;
    private ErrorProvider errorNoLog;
    private ErrorProvider errorNoPassword;
    private CheckBox checkViewPassword;
    private Button buttChangeDataOfUser;
    private ErrorProvider errorWrongLogOrPassword;
    private ErrorProvider errorWrongPassword;
    private Label labelWrongLogOrPassword;
}