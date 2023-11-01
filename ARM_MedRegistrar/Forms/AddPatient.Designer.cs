namespace ARM_MedRegistrar;

partial class AddPatient
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
        label1 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.Firebrick;
        label1.Location = new Point(268, 45);
        label1.Name = "label1";
        label1.Size = new Size(232, 28);
        label1.TabIndex = 0;
        label1.Text = "Добавление пациента\r\n";
        // 
        // AddPatient
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(803, 491);
        Controls.Add(label1);
        Name = "AddPatient";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AddPatient";
        Load += AddPatient_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
}