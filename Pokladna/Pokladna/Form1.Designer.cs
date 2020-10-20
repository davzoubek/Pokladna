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
            this.gBoxObdobi.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.gBoxObdobi);
            this.Controls.Add(this.listViewData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBoxObdobi.ResumeLayout(false);
            this.gBoxObdobi.PerformLayout();
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
    }
}

