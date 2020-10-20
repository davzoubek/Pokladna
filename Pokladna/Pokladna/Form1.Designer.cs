namespace Pokladna
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBoxObdobi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxRok = new System.Windows.Forms.ComboBox();
            this.cBoxMesic = new System.Windows.Forms.ComboBox();
            this.polozkaGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dokladTextBox = new System.Windows.Forms.TextBox();
            this.popisTextBox = new System.Windows.Forms.TextBox();
            this.castkaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.poznamkaTextBox = new System.Windows.Forms.TextBox();
            this.ulozitButton = new System.Windows.Forms.Button();
            this.ulozitjakoButton = new System.Windows.Forms.Button();
            this.gBoxObdobi.SuspendLayout();
            this.polozkaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.castkaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewData
            // 
            this.listViewData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewData.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewData.FullRowSelect = true;
            this.listViewData.GridLines = true;
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(165, 0);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(470, 450);
            this.listViewData.TabIndex = 0;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Č_dokladu";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Popis";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Příjem";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Výdej";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zůstatek";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Poznámka";
            // 
            // gBoxObdobi
            // 
            this.gBoxObdobi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxObdobi.Controls.Add(this.cBoxMesic);
            this.gBoxObdobi.Controls.Add(this.cBoxRok);
            this.gBoxObdobi.Controls.Add(this.label2);
            this.gBoxObdobi.Controls.Add(this.label1);
            this.gBoxObdobi.Location = new System.Drawing.Point(0, 0);
            this.gBoxObdobi.Name = "gBoxObdobi";
            this.gBoxObdobi.Size = new System.Drawing.Size(165, 84);
            this.gBoxObdobi.TabIndex = 1;
            this.gBoxObdobi.TabStop = false;
            this.gBoxObdobi.Text = "Účetní období";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Měsíc:";
            // 
            // cBoxRok
            // 
            this.cBoxRok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRok.FormattingEnabled = true;
            this.cBoxRok.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.cBoxRok.Location = new System.Drawing.Point(48, 17);
            this.cBoxRok.Name = "cBoxRok";
            this.cBoxRok.Size = new System.Drawing.Size(111, 21);
            this.cBoxRok.TabIndex = 2;
            this.cBoxRok.SelectedIndexChanged += new System.EventHandler(this.CBoxRok_SelectedIndexChanged);
            // 
            // cBoxMesic
            // 
            this.cBoxMesic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMesic.FormattingEnabled = true;
            this.cBoxMesic.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen",
            "Červenec",
            "Srpen",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
            this.cBoxMesic.Location = new System.Drawing.Point(49, 48);
            this.cBoxMesic.Name = "cBoxMesic";
            this.cBoxMesic.Size = new System.Drawing.Size(110, 21);
            this.cBoxMesic.TabIndex = 3;
            this.cBoxMesic.SelectedIndexChanged += new System.EventHandler(this.CBoxMesic_SelectedIndexChanged);
            // 
            // polozkaGroupBox
            // 
            this.polozkaGroupBox.Controls.Add(this.ulozitjakoButton);
            this.polozkaGroupBox.Controls.Add(this.ulozitButton);
            this.polozkaGroupBox.Controls.Add(this.poznamkaTextBox);
            this.polozkaGroupBox.Controls.Add(this.label7);
            this.polozkaGroupBox.Controls.Add(this.castkaNumericUpDown);
            this.polozkaGroupBox.Controls.Add(this.popisTextBox);
            this.polozkaGroupBox.Controls.Add(this.dokladTextBox);
            this.polozkaGroupBox.Controls.Add(this.label6);
            this.polozkaGroupBox.Controls.Add(this.label5);
            this.polozkaGroupBox.Controls.Add(this.datumDateTimePicker);
            this.polozkaGroupBox.Controls.Add(this.label4);
            this.polozkaGroupBox.Controls.Add(this.label3);
            this.polozkaGroupBox.Location = new System.Drawing.Point(0, 90);
            this.polozkaGroupBox.Name = "polozkaGroupBox";
            this.polozkaGroupBox.Size = new System.Drawing.Size(165, 243);
            this.polozkaGroupBox.TabIndex = 2;
            this.polozkaGroupBox.TabStop = false;
            this.polozkaGroupBox.Text = "Položka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Částka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datum:";
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTimePicker.Location = new System.Drawing.Point(53, 26);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.datumDateTimePicker.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Č. dokladu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Popis";
            // 
            // dokladTextBox
            // 
            this.dokladTextBox.Location = new System.Drawing.Point(65, 60);
            this.dokladTextBox.Name = "dokladTextBox";
            this.dokladTextBox.Size = new System.Drawing.Size(94, 20);
            this.dokladTextBox.TabIndex = 6;
            this.dokladTextBox.TextChanged += new System.EventHandler(this.DokladTextBox_TextChanged);
            // 
            // popisTextBox
            // 
            this.popisTextBox.Location = new System.Drawing.Point(65, 87);
            this.popisTextBox.Name = "popisTextBox";
            this.popisTextBox.Size = new System.Drawing.Size(94, 20);
            this.popisTextBox.TabIndex = 7;
            this.popisTextBox.TextChanged += new System.EventHandler(this.PopisTextBox_TextChanged);
            // 
            // castkaNumericUpDown
            // 
            this.castkaNumericUpDown.Location = new System.Drawing.Point(48, 118);
            this.castkaNumericUpDown.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.castkaNumericUpDown.Minimum = new decimal(new int[] {
            200000,
            0,
            0,
            -2147483648});
            this.castkaNumericUpDown.Name = "castkaNumericUpDown";
            this.castkaNumericUpDown.Size = new System.Drawing.Size(111, 20);
            this.castkaNumericUpDown.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Poznámka:";
            // 
            // poznamkaTextBox
            // 
            this.poznamkaTextBox.Location = new System.Drawing.Point(65, 150);
            this.poznamkaTextBox.Name = "poznamkaTextBox";
            this.poznamkaTextBox.Size = new System.Drawing.Size(94, 20);
            this.poznamkaTextBox.TabIndex = 10;
            // 
            // ulozitButton
            // 
            this.ulozitButton.Enabled = false;
            this.ulozitButton.Location = new System.Drawing.Point(84, 187);
            this.ulozitButton.Name = "ulozitButton";
            this.ulozitButton.Size = new System.Drawing.Size(75, 50);
            this.ulozitButton.TabIndex = 11;
            this.ulozitButton.Text = "Uložit";
            this.ulozitButton.UseVisualStyleBackColor = true;
            // 
            // ulozitjakoButton
            // 
            this.ulozitjakoButton.Enabled = false;
            this.ulozitjakoButton.Location = new System.Drawing.Point(6, 187);
            this.ulozitjakoButton.Name = "ulozitjakoButton";
            this.ulozitjakoButton.Size = new System.Drawing.Size(75, 50);
            this.ulozitjakoButton.TabIndex = 12;
            this.ulozitjakoButton.Text = "Uložit jako nový";
            this.ulozitjakoButton.UseVisualStyleBackColor = true;
            this.ulozitjakoButton.Click += new System.EventHandler(this.UlozitjakoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.polozkaGroupBox);
            this.Controls.Add(this.gBoxObdobi);
            this.Controls.Add(this.listViewData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBoxObdobi.ResumeLayout(false);
            this.gBoxObdobi.PerformLayout();
            this.polozkaGroupBox.ResumeLayout(false);
            this.polozkaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.castkaNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox gBoxObdobi;
        private System.Windows.Forms.ComboBox cBoxMesic;
        private System.Windows.Forms.ComboBox cBoxRok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox polozkaGroupBox;
        private System.Windows.Forms.Button ulozitjakoButton;
        private System.Windows.Forms.Button ulozitButton;
        private System.Windows.Forms.TextBox poznamkaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown castkaNumericUpDown;
        private System.Windows.Forms.TextBox popisTextBox;
        private System.Windows.Forms.TextBox dokladTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

