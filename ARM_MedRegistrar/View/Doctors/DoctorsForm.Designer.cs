namespace ARM_MedRegistrar.View.Doctors
{
    partial class DoctorsForm
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
            listViewDoctors = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            buttAddDoctor = new Button();
            buttSearchDoctor = new Button();
            buttAllDataAboutDoctor = new Button();
            richTextBoxInfoAboutDoctor = new RichTextBox();
            buttRemoveDoctor = new Button();
            buttAllDoctors = new Button();
            buttChangeData = new Button();
            textSurname = new TextBox();
            textName = new TextBox();
            textPatr = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxSpecializations = new ComboBox();
            label5 = new Label();
            toolTipAllDataAboutDoctors = new ToolTip(components);
            toolTipRemoveDoctor = new ToolTip(components);
            errorNoName = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorNoSpecialization = new ErrorProvider(components);
            checkIsMultiSelect = new CheckBox();
            errorMultiSelect = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSpecialization).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorMultiSelect).BeginInit();
            SuspendLayout();
            // 
            // listViewDoctors
            // 
            listViewDoctors.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader1, columnHeader2, columnHeader3, columnHeader6, columnHeader4, columnHeader5 });
            listViewDoctors.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listViewDoctors.Location = new Point(12, 320);
            listViewDoctors.MultiSelect = false;
            listViewDoctors.Name = "listViewDoctors";
            listViewDoctors.Size = new Size(1126, 498);
            listViewDoctors.TabIndex = 39;
            listViewDoctors.UseCompatibleStateImageBehavior = false;
            listViewDoctors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID";
            columnHeader7.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Фамилия";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Имя";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Отчество";
            columnHeader3.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Специализация";
            columnHeader6.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Кабинет";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Участок";
            columnHeader5.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(33, 24);
            label2.Name = "label2";
            label2.Size = new Size(109, 41);
            label2.TabIndex = 40;
            label2.Text = "Врачи";
            // 
            // buttAddDoctor
            // 
            buttAddDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttAddDoctor.ForeColor = Color.Firebrick;
            buttAddDoctor.Location = new Point(211, 24);
            buttAddDoctor.Name = "buttAddDoctor";
            buttAddDoctor.Size = new Size(339, 52);
            buttAddDoctor.TabIndex = 41;
            buttAddDoctor.Text = "Добавить врача";
            buttAddDoctor.UseVisualStyleBackColor = true;
            buttAddDoctor.Click += buttAddDoctor_Click;
            // 
            // buttSearchDoctor
            // 
            buttSearchDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearchDoctor.ForeColor = Color.Firebrick;
            buttSearchDoctor.Location = new Point(873, 162);
            buttSearchDoctor.Name = "buttSearchDoctor";
            buttSearchDoctor.Size = new Size(265, 112);
            buttSearchDoctor.TabIndex = 42;
            buttSearchDoctor.Text = "Найти врача\r\n";
            buttSearchDoctor.UseVisualStyleBackColor = true;
            buttSearchDoctor.Click += buttSearchDoctor_Click;
            // 
            // buttAllDataAboutDoctor
            // 
            buttAllDataAboutDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllDataAboutDoctor.Location = new Point(1462, 129);
            buttAllDataAboutDoctor.Name = "buttAllDataAboutDoctor";
            buttAllDataAboutDoctor.Size = new Size(410, 73);
            buttAllDataAboutDoctor.TabIndex = 48;
            buttAllDataAboutDoctor.Text = "Все данные о выбранном враче";
            buttAllDataAboutDoctor.UseVisualStyleBackColor = true;
            buttAllDataAboutDoctor.Click += buttAllDataAboutDoctor_Click;
            // 
            // richTextBoxInfoAboutDoctor
            // 
            richTextBoxInfoAboutDoctor.BackColor = SystemColors.Window;
            richTextBoxInfoAboutDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxInfoAboutDoctor.Location = new Point(1276, 228);
            richTextBoxInfoAboutDoctor.Name = "richTextBoxInfoAboutDoctor";
            richTextBoxInfoAboutDoctor.ReadOnly = true;
            richTextBoxInfoAboutDoctor.Size = new Size(596, 590);
            richTextBoxInfoAboutDoctor.TabIndex = 49;
            richTextBoxInfoAboutDoctor.Text = "";
            // 
            // buttRemoveDoctor
            // 
            buttRemoveDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttRemoveDoctor.ForeColor = Color.Firebrick;
            buttRemoveDoctor.Location = new Point(13, 896);
            buttRemoveDoctor.Name = "buttRemoveDoctor";
            buttRemoveDoctor.Size = new Size(193, 69);
            buttRemoveDoctor.TabIndex = 50;
            buttRemoveDoctor.Text = "Удалить врача";
            buttRemoveDoctor.UseVisualStyleBackColor = true;
            buttRemoveDoctor.Click += buttRemoveDoctor_Click;
            // 
            // buttAllDoctors
            // 
            buttAllDoctors.BackColor = Color.MistyRose;
            buttAllDoctors.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllDoctors.ForeColor = Color.Firebrick;
            buttAllDoctors.Location = new Point(805, 896);
            buttAllDoctors.Name = "buttAllDoctors";
            buttAllDoctors.Size = new Size(333, 69);
            buttAllDoctors.TabIndex = 51;
            buttAllDoctors.Text = "Обновить список врачей\r\n";
            buttAllDoctors.UseVisualStyleBackColor = false;
            buttAllDoctors.Click += buttAllDoctors_Click;
            // 
            // buttChangeData
            // 
            buttChangeData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttChangeData.Location = new Point(1505, 896);
            buttChangeData.Name = "buttChangeData";
            buttChangeData.Size = new Size(367, 74);
            buttChangeData.TabIndex = 52;
            buttChangeData.Text = "Изменить данные врача\r\n";
            buttChangeData.UseVisualStyleBackColor = true;
            buttChangeData.Click += buttChangeData_Click;
            // 
            // textSurname
            // 
            textSurname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(33, 163);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(328, 39);
            textSurname.TabIndex = 53;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(33, 257);
            textName.Name = "textName";
            textName.Size = new Size(328, 39);
            textName.TabIndex = 54;
            // 
            // textPatr
            // 
            textPatr.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(460, 162);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(328, 39);
            textPatr.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(460, 127);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 32);
            label6.TabIndex = 60;
            label6.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(33, 127);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 58;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(33, 222);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 32);
            label4.TabIndex = 59;
            label4.Text = "Имя";
            // 
            // comboBoxSpecializations
            // 
            comboBoxSpecializations.BackColor = Color.White;
            comboBoxSpecializations.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecializations.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSpecializations.ForeColor = Color.Firebrick;
            comboBoxSpecializations.FormattingEnabled = true;
            comboBoxSpecializations.Location = new Point(460, 258);
            comboBoxSpecializations.Margin = new Padding(4);
            comboBoxSpecializations.Name = "comboBoxSpecializations";
            comboBoxSpecializations.Size = new Size(328, 39);
            comboBoxSpecializations.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(460, 222);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 32);
            label5.TabIndex = 62;
            label5.Text = "Специализация";
            // 
            // errorNoName
            // 
            errorNoName.ContainerControl = this;
            // 
            // errorNoSurname
            // 
            errorNoSurname.ContainerControl = this;
            // 
            // errorNoSpecialization
            // 
            errorNoSpecialization.ContainerControl = this;
            // 
            // checkIsMultiSelect
            // 
            checkIsMultiSelect.AutoSize = true;
            checkIsMultiSelect.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsMultiSelect.ForeColor = Color.Firebrick;
            checkIsMultiSelect.Location = new Point(402, 913);
            checkIsMultiSelect.Name = "checkIsMultiSelect";
            checkIsMultiSelect.Size = new Size(329, 36);
            checkIsMultiSelect.TabIndex = 63;
            checkIsMultiSelect.Text = "Выбор нескольких врачей";
            checkIsMultiSelect.UseVisualStyleBackColor = true;
            checkIsMultiSelect.CheckedChanged += checkIsMultiSelect_CheckedChanged;
            // 
            // errorMultiSelect
            // 
            errorMultiSelect.ContainerControl = this;
            // 
            // DoctorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1902, 1033);
            Controls.Add(checkIsMultiSelect);
            Controls.Add(label5);
            Controls.Add(comboBoxSpecializations);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textPatr);
            Controls.Add(textName);
            Controls.Add(textSurname);
            Controls.Add(buttChangeData);
            Controls.Add(buttAllDoctors);
            Controls.Add(buttRemoveDoctor);
            Controls.Add(richTextBoxInfoAboutDoctor);
            Controls.Add(buttAllDataAboutDoctor);
            Controls.Add(buttSearchDoctor);
            Controls.Add(buttAddDoctor);
            Controls.Add(label2);
            Controls.Add(listViewDoctors);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DoctorsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARM_MedRegistrar";
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSpecialization).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorMultiSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewDoctors;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label2;
        private Button buttAddDoctor;
        private Button buttSearchDoctor;
        private Button buttAllDataAboutDoctor;
        private RichTextBox richTextBoxInfoAboutDoctor;
        private Button buttRemoveDoctor;
        private Button buttAllDoctors;
        private Button buttChangeData;
        private TextBox textSurname;
        private TextBox textName;
        private TextBox textPatr;
        private Label label6;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxSpecializations;
        private Label label5;
        private ToolTip toolTipAllDataAboutDoctors;
        private ToolTip toolTipRemoveDoctor;
        private ErrorProvider errorNoName;
        private ErrorProvider errorNoSurname;
        private ErrorProvider errorNoSpecialization;
        private CheckBox checkIsMultiSelect;
        private ErrorProvider errorMultiSelect;
    }
}