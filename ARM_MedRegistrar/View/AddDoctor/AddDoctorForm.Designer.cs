namespace ARM_MedRegistrar;

partial class AddDoctorForm
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
        label2 = new Label();
        comboBoxSpecializations = new ComboBox();
        textSurname = new TextBox();
        textName = new TextBox();
        textPatr = new TextBox();
        buttAddDoctor = new Button();
        label3 = new Label();
        label1 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        errorNoSurname = new ErrorProvider(components);
        errorNoName = new ErrorProvider(components);
        errorNoCabinet = new ErrorProvider(components);
        errorNoSpecial = new ErrorProvider(components);
        checkNoCloseWindow = new CheckBox();
        textPhoneNumber = new TextBox();
        label8 = new Label();
        errorNoPhoneNumber = new ErrorProvider(components);
        toolEnterPhoneNumb = new ToolTip(components);
        textPlotNumber = new TextBox();
        textCabinet = new TextBox();
        errorNoPlotNumber = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoCabinet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSpecial).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).BeginInit();
        SuspendLayout();
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.Firebrick;
        label2.Location = new Point(207, 50);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(268, 37);
        label2.TabIndex = 2;
        label2.Text = "Добавление врача";
        // 
        // comboBoxSpecializations
        // 
        comboBoxSpecializations.BackColor = Color.White;
        comboBoxSpecializations.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxSpecializations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        comboBoxSpecializations.ForeColor = Color.Firebrick;
        comboBoxSpecializations.FormattingEnabled = true;
        comboBoxSpecializations.Location = new Point(413, 142);
        comboBoxSpecializations.Margin = new Padding(4);
        comboBoxSpecializations.Name = "comboBoxSpecializations";
        comboBoxSpecializations.Size = new Size(252, 36);
        comboBoxSpecializations.TabIndex = 3;
        // 
        // textSurname
        // 
        textSurname.BackColor = Color.White;
        textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textSurname.Location = new Point(16, 144);
        textSurname.Margin = new Padding(4);
        textSurname.Name = "textSurname";
        textSurname.Size = new Size(312, 34);
        textSurname.TabIndex = 20;
        textSurname.KeyPress += textBox_SpacePress;
        // 
        // textName
        // 
        textName.BackColor = Color.White;
        textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textName.Location = new Point(16, 261);
        textName.Margin = new Padding(4);
        textName.Name = "textName";
        textName.Size = new Size(312, 34);
        textName.TabIndex = 21;
        textName.KeyPress += textBox_SpacePress;
        // 
        // textPatr
        // 
        textPatr.BackColor = Color.White;
        textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPatr.Location = new Point(13, 370);
        textPatr.Margin = new Padding(4);
        textPatr.Name = "textPatr";
        textPatr.Size = new Size(315, 34);
        textPatr.TabIndex = 22;
        textPatr.KeyPress += textBox_SpacePress;
        // 
        // buttAddDoctor
        // 
        buttAddDoctor.BackColor = Color.FromArgb(255, 192, 192);
        buttAddDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        buttAddDoctor.ForeColor = Color.Firebrick;
        buttAddDoctor.Location = new Point(263, 572);
        buttAddDoctor.Margin = new Padding(4);
        buttAddDoctor.Name = "buttAddDoctor";
        buttAddDoctor.Size = new Size(172, 53);
        buttAddDoctor.TabIndex = 25;
        buttAddDoctor.Text = "Добавить";
        buttAddDoctor.UseVisualStyleBackColor = false;
        buttAddDoctor.Click += buttAddDoctor_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.Firebrick;
        label3.Location = new Point(16, 112);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(96, 28);
        label3.TabIndex = 28;
        label3.Text = "Фамилия";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.Firebrick;
        label1.Location = new Point(16, 229);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(51, 28);
        label1.TabIndex = 29;
        label1.Text = "Имя";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.Firebrick;
        label4.Location = new Point(13, 338);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(234, 28);
        label4.TabIndex = 30;
        label4.Text = "Отчество (при наличии)";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label5.ForeColor = Color.Firebrick;
        label5.Location = new Point(413, 110);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(156, 28);
        label5.TabIndex = 31;
        label5.Text = "Специализация";
        label5.Click += label5_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label6.ForeColor = Color.Firebrick;
        label6.Location = new Point(413, 229);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(147, 28);
        label6.TabIndex = 32;
        label6.Text = "Номер участка";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label7.ForeColor = Color.Firebrick;
        label7.Location = new Point(413, 338);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(163, 28);
        label7.TabIndex = 33;
        label7.Text = "Номер кабинета";
        // 
        // errorNoSurname
        // 
        errorNoSurname.ContainerControl = this;
        // 
        // errorNoName
        // 
        errorNoName.ContainerControl = this;
        // 
        // errorNoCabinet
        // 
        errorNoCabinet.ContainerControl = this;
        // 
        // errorNoSpecial
        // 
        errorNoSpecial.ContainerControl = this;
        // 
        // checkNoCloseWindow
        // 
        checkNoCloseWindow.AutoSize = true;
        checkNoCloseWindow.ForeColor = Color.Black;
        checkNoCloseWindow.Location = new Point(465, 584);
        checkNoCloseWindow.Name = "checkNoCloseWindow";
        checkNoCloseWindow.Size = new Size(213, 32);
        checkNoCloseWindow.TabIndex = 34;
        checkNoCloseWindow.Text = "Не закрывать окно ";
        checkNoCloseWindow.UseVisualStyleBackColor = true;
        // 
        // textPhoneNumber
        // 
        textPhoneNumber.BackColor = Color.White;
        textPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPhoneNumber.Location = new Point(13, 475);
        textPhoneNumber.Margin = new Padding(4);
        textPhoneNumber.Name = "textPhoneNumber";
        textPhoneNumber.Size = new Size(315, 34);
        textPhoneNumber.TabIndex = 36;
        textPhoneNumber.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label8.ForeColor = Color.Firebrick;
        label8.Location = new Point(13, 443);
        label8.Margin = new Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new Size(166, 28);
        label8.TabIndex = 37;
        label8.Text = "Номер телефона\r\n";
        // 
        // errorNoPhoneNumber
        // 
        errorNoPhoneNumber.ContainerControl = this;
        // 
        // textPlotNumber
        // 
        textPlotNumber.BackColor = Color.White;
        textPlotNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPlotNumber.Location = new Point(413, 282);
        textPlotNumber.Margin = new Padding(4);
        textPlotNumber.Name = "textPlotNumber";
        textPlotNumber.Size = new Size(198, 34);
        textPlotNumber.TabIndex = 38;
        textPlotNumber.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // textCabinet
        // 
        textCabinet.BackColor = Color.White;
        textCabinet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textCabinet.Location = new Point(413, 396);
        textCabinet.Margin = new Padding(4);
        textCabinet.Name = "textCabinet";
        textCabinet.Size = new Size(198, 34);
        textCabinet.TabIndex = 39;
        textCabinet.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // errorNoPlotNumber
        // 
        errorNoPlotNumber.ContainerControl = this;
        // 
        // AddDoctorForm
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(704, 658);
        Controls.Add(textCabinet);
        Controls.Add(textPlotNumber);
        Controls.Add(label8);
        Controls.Add(textPhoneNumber);
        Controls.Add(checkNoCloseWindow);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label1);
        Controls.Add(label3);
        Controls.Add(buttAddDoctor);
        Controls.Add(textPatr);
        Controls.Add(textName);
        Controls.Add(textSurname);
        Controls.Add(comboBoxSpecializations);
        Controls.Add(label2);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "AddDoctorForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AddDoctor";
        ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoCabinet).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSpecial).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label2;

    public AddDoctorForm(Label label2)
    {
        label2 = label2;
    }

    private ComboBox comboBoxSpecializations;
    private TextBox textSurname;
    private TextBox textName;
    private TextBox textPatr;
    private Button buttAddDoctor;
    private Label label3;
    private Label label1;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private ErrorProvider errorNoSurname;
    private ErrorProvider errorNoName;
    private ErrorProvider errorNoCabinet;
    private ErrorProvider errorNoSpecial;
    private CheckBox checkNoCloseWindow;
    private Label label8;
    private TextBox textPhoneNumber;
    private ErrorProvider errorNoPhoneNumber;
    private ToolTip toolEnterPhoneNumb;
    private TextBox textCabinet;
    private TextBox textPlotNumber;
    private ErrorProvider errorNoPlotNumber;
}