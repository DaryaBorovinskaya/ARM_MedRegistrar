namespace ARM_MedRegistrar.View
{
    partial class AttachedStreetsForm
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
            label1 = new Label();
            buttOpenFile = new Button();
            listBoxAttachedStreets = new ListBox();
            buttAddDataToFile = new Button();
            buttRemoveDataToFile = new Button();
            textCity = new TextBox();
            textRegion = new TextBox();
            label14 = new Label();
            label13 = new Label();
            textStreet = new TextBox();
            label12 = new Label();
            errorNoStreet = new ErrorProvider(components);
            label2 = new Label();
            errorNoCity = new ErrorProvider(components);
            errorNoRegion = new ErrorProvider(components);
            label3 = new Label();
            errorNoNumbOfHouse = new ErrorProvider(components);
            textNumbOfHouse = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorNoStreet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoRegion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNumbOfHouse).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(198, 62);
            label1.TabIndex = 0;
            label1.Text = "Прикреплённые\r\nулицы";
            // 
            // buttOpenFile
            // 
            buttOpenFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttOpenFile.ForeColor = Color.Black;
            buttOpenFile.Location = new Point(488, 30);
            buttOpenFile.Name = "buttOpenFile";
            buttOpenFile.Size = new Size(180, 74);
            buttOpenFile.TabIndex = 1;
            buttOpenFile.Text = "Просмотреть файл";
            buttOpenFile.UseVisualStyleBackColor = true;
            // 
            // listBoxAttachedStreets
            // 
            listBoxAttachedStreets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxAttachedStreets.FormattingEnabled = true;
            listBoxAttachedStreets.ItemHeight = 28;
            listBoxAttachedStreets.Location = new Point(684, 30);
            listBoxAttachedStreets.Name = "listBoxAttachedStreets";
            listBoxAttachedStreets.Size = new Size(624, 704);
            listBoxAttachedStreets.TabIndex = 2;
            // 
            // buttAddDataToFile
            // 
            buttAddDataToFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddDataToFile.ForeColor = Color.Firebrick;
            buttAddDataToFile.Location = new Point(29, 558);
            buttAddDataToFile.Name = "buttAddDataToFile";
            buttAddDataToFile.Size = new Size(179, 72);
            buttAddDataToFile.TabIndex = 3;
            buttAddDataToFile.Text = "Добавить данные в файл";
            buttAddDataToFile.UseVisualStyleBackColor = true;
            buttAddDataToFile.Click += buttAddDataToFile_Click;
            // 
            // buttRemoveDataToFile
            // 
            buttRemoveDataToFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttRemoveDataToFile.ForeColor = Color.Firebrick;
            buttRemoveDataToFile.Location = new Point(385, 558);
            buttRemoveDataToFile.Name = "buttRemoveDataToFile";
            buttRemoveDataToFile.Size = new Size(179, 72);
            buttRemoveDataToFile.TabIndex = 4;
            buttRemoveDataToFile.Text = "Удалить данные из файла";
            buttRemoveDataToFile.UseVisualStyleBackColor = true;
            // 
            // textCity
            // 
            textCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textCity.Location = new Point(146, 195);
            textCity.Name = "textCity";
            textCity.Size = new Size(313, 34);
            textCity.TabIndex = 51;
            textCity.KeyPress += textBox_SpacePress;
            // 
            // textRegion
            // 
            textRegion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textRegion.Location = new Point(146, 316);
            textRegion.Name = "textRegion";
            textRegion.Size = new Size(313, 34);
            textRegion.TabIndex = 52;
            textRegion.KeyPress += textBox_SpacePress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Firebrick;
            label14.Location = new Point(267, 142);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(68, 28);
            label14.TabIndex = 58;
            label14.Text = "Город";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Firebrick;
            label13.Location = new Point(267, 261);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(69, 28);
            label13.TabIndex = 59;
            label13.Text = "Район";
            
            // 
            // textStreet
            // 
            textStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textStreet.Location = new Point(22, 424);
            textStreet.Name = "textStreet";
            textStreet.Size = new Size(313, 34);
            textStreet.TabIndex = 60;
            textStreet.KeyPress += textBox_SpacePress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Firebrick;
            label12.Location = new Point(122, 382);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 28);
            label12.TabIndex = 61;
            label12.Text = "Улица";
            // 
            // errorNoStreet
            // 
            errorNoStreet.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(216, 91);
            label2.Name = "label2";
            label2.Size = new Size(188, 31);
            label2.TabIndex = 64;
            label2.Text = "Введите данные:";
            // 
            // errorNoCity
            // 
            errorNoCity.ContainerControl = this;
            // 
            // errorNoRegion
            // 
            errorNoRegion.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(416, 382);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 66;
            label3.Text = "Номер дома";
            // 
            // errorNoNumbOfHouse
            // 
            errorNoNumbOfHouse.ContainerControl = this;
            // 
            // textNumbOfHouse
            // 
            textNumbOfHouse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNumbOfHouse.Location = new Point(416, 424);
            textNumbOfHouse.Name = "textNumbOfHouse";
            textNumbOfHouse.Size = new Size(125, 34);
            textNumbOfHouse.TabIndex = 106;
            textNumbOfHouse.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // AttachedStreetsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1320, 746);
            Controls.Add(textNumbOfHouse);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(textStreet);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(textRegion);
            Controls.Add(textCity);
            Controls.Add(buttRemoveDataToFile);
            Controls.Add(buttAddDataToFile);
            Controls.Add(listBoxAttachedStreets);
            Controls.Add(buttOpenFile);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AttachedStreetsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttachedStreetsForm";
            
            ((System.ComponentModel.ISupportInitialize)errorNoStreet).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCity).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoRegion).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNumbOfHouse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttOpenFile;
        private ListBox listBoxAttachedStreets;
        private Button buttAddDataToFile;
        private Button buttRemoveDataToFile;
        private TextBox textCity;
        private TextBox textRegion;
        private Label label14;
        private Label label13;
        private TextBox textStreet;
        private Label label12;
        private ErrorProvider errorNoStreet;
        private Label label2;
        private ErrorProvider errorNoCity;
        private ErrorProvider errorNoRegion;
        private Label label3;
        private ErrorProvider errorNoNumbOfHouse;
        private TextBox textNumbOfHouse;
    }
}