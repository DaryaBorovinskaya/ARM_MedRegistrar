namespace ARM_MedRegistrar;

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
        buttEntrance = new Button();
        textLog = new TextBox();
        textPassword = new TextBox();
        labelLog = new Label();
        labelPassword = new Label();
        buttonRegistration = new Button();
        labelName = new Label();
        buttonExit = new Button();
        SuspendLayout();
        // 
        // buttEntrance
        // 
        buttEntrance.BackColor = Color.FromArgb(255, 192, 192);
        buttEntrance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        buttEntrance.ForeColor = Color.Firebrick;
        buttEntrance.Location = new Point(312, 310);
        buttEntrance.Name = "buttEntrance";
        buttEntrance.Size = new Size(159, 52);
        buttEntrance.TabIndex = 0;
        buttEntrance.Text = "Войти";
        buttEntrance.UseVisualStyleBackColor = false;
        buttEntrance.Click += buttEntrance_Click;
        // 
        // textLog
        // 
        textLog.BackColor = Color.Snow;
        textLog.Location = new Point(239, 174);
        textLog.Name = "textLog";
        textLog.Size = new Size(329, 27);
        textLog.TabIndex = 1;
        // 
        // textPassword
        // 
        textPassword.BackColor = Color.Snow;
        textPassword.Location = new Point(239, 263);
        textPassword.Name = "textPassword";
        textPassword.Size = new Size(329, 27);
        textPassword.TabIndex = 2;
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
        buttonRegistration.Font = new Font("Trebuchet MS", 9F, FontStyle.Underline, GraphicsUnit.Point);
        buttonRegistration.ForeColor = Color.Black;
        buttonRegistration.Location = new Point(303, 379);
        buttonRegistration.Name = "buttonRegistration";
        buttonRegistration.Size = new Size(178, 29);
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
        // buttonExit
        // 
        buttonExit.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
        buttonExit.ForeColor = Color.Red;
        buttonExit.Location = new Point(765, 0);
        buttonExit.Name = "buttonExit";
        buttonExit.Size = new Size(37, 37);
        buttonExit.TabIndex = 7;
        buttonExit.Text = "Х";
        buttonExit.UseVisualStyleBackColor = true;
        buttonExit.Click += buttonExit_Click;
        // 
        // Entrance
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(803, 491);
        Controls.Add(buttonExit);
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
    private Button buttonExit;
}