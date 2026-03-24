namespace RAD_SA_VIŠE_FORMI
{
    partial class FormUnosNovogStudenta
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
            textBoxIme = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxBrojIndeksa = new TextBox();
            comboBoxSmjer = new ComboBox();
            dateTimePickerDatumRodjenja = new DateTimePicker();
            buttonSnimi = new Button();
            buttonOtkazi = new Button();
            SuspendLayout();
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(35, 40);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(271, 23);
            textBoxIme.TabIndex = 0;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(35, 96);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(271, 23);
            textBoxPrezime.TabIndex = 1;
            // 
            // textBoxBrojIndeksa
            // 
            textBoxBrojIndeksa.Location = new Point(35, 155);
            textBoxBrojIndeksa.Name = "textBoxBrojIndeksa";
            textBoxBrojIndeksa.Size = new Size(271, 23);
            textBoxBrojIndeksa.TabIndex = 2;
            // 
            // comboBoxSmjer
            // 
            comboBoxSmjer.FormattingEnabled = true;
            comboBoxSmjer.Location = new Point(406, 40);
            comboBoxSmjer.Name = "comboBoxSmjer";
            comboBoxSmjer.Size = new Size(217, 23);
            comboBoxSmjer.TabIndex = 3;
            comboBoxSmjer.SelectedIndexChanged += comboBoxSmjer_SelectedIndexChanged;
            // 
            // dateTimePickerDatumRodjenja
            // 
            dateTimePickerDatumRodjenja.Location = new Point(406, 96);
            dateTimePickerDatumRodjenja.Name = "dateTimePickerDatumRodjenja";
            dateTimePickerDatumRodjenja.Size = new Size(242, 23);
            dateTimePickerDatumRodjenja.TabIndex = 4;
            // 
            // buttonSnimi
            // 
            buttonSnimi.Location = new Point(406, 154);
            buttonSnimi.Name = "buttonSnimi";
            buttonSnimi.Size = new Size(109, 23);
            buttonSnimi.TabIndex = 5;
            buttonSnimi.Text = "Snimi";
            buttonSnimi.UseVisualStyleBackColor = true;
            buttonSnimi.Click += buttonSnimi_Click;
            // 
            // buttonOtkazi
            // 
            buttonOtkazi.Location = new Point(548, 155);
            buttonOtkazi.Name = "buttonOtkazi";
            buttonOtkazi.Size = new Size(122, 23);
            buttonOtkazi.TabIndex = 6;
            buttonOtkazi.Text = "Otkaži";
            buttonOtkazi.UseVisualStyleBackColor = true;
            buttonOtkazi.Click += buttonOtkazi_Click;
            // 
            // FormUnosNovogStudenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOtkazi);
            Controls.Add(buttonSnimi);
            Controls.Add(dateTimePickerDatumRodjenja);
            Controls.Add(comboBoxSmjer);
            Controls.Add(textBoxBrojIndeksa);
            Controls.Add(textBoxPrezime);
            Controls.Add(textBoxIme);
            Name = "FormUnosNovogStudenta";
            Text = "FormUnosNovogStudenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIme;
        private TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxBrojIndeksa;
        private ComboBox comboBoxSmjer;
        private DateTimePicker dateTimePickerDatumRodjenja;
        private Button buttonSnimi;
        private Button buttonOtkazi;
    }
}