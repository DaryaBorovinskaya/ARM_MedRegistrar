namespace ARM_MedRegistrar;

partial class AddDoctor
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
        label2 = new Label();
        SuspendLayout();
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.Firebrick;
        label2.Location = new Point(270, 49);
        label2.Name = "label2";
        label2.Size = new Size(198, 28);
        label2.TabIndex = 2;
        label2.Text = "Добавление врача";
        // 
        // AddDoctor
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(803, 491);
        Controls.Add(label2);
        Name = "AddDoctor";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AddDoctor";
        Load += AddDoctor_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label2;

    public AddDoctor(Label label2)
    {
        this.label2 = label2;
    }
}