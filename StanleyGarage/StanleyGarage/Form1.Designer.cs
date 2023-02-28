
namespace StanleyGarage
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_dodaj_naprawę = new System.Windows.Forms.Button();
            this.button_edytuj_naprawę = new System.Windows.Forms.Button();
            this.button_usuń_naprawę = new System.Windows.Forms.Button();
            this.button_Raport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(635, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mechanik";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Data oddania do naprawy";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nazwa naprawy";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Numer rejestracyjny";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Koszt części";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Czas pracy mechanika";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // button_dodaj_naprawę
            // 
            this.button_dodaj_naprawę.Location = new System.Drawing.Point(13, 370);
            this.button_dodaj_naprawę.Name = "button_dodaj_naprawę";
            this.button_dodaj_naprawę.Size = new System.Drawing.Size(110, 23);
            this.button_dodaj_naprawę.TabIndex = 1;
            this.button_dodaj_naprawę.Text = "Dodaj naprawę";
            this.button_dodaj_naprawę.UseVisualStyleBackColor = true;
            this.button_dodaj_naprawę.Click += new System.EventHandler(this.button_dodaj_naprawę_Click);
            // 
            // button_edytuj_naprawę
            // 
            this.button_edytuj_naprawę.Location = new System.Drawing.Point(150, 370);
            this.button_edytuj_naprawę.Name = "button_edytuj_naprawę";
            this.button_edytuj_naprawę.Size = new System.Drawing.Size(121, 23);
            this.button_edytuj_naprawę.TabIndex = 2;
            this.button_edytuj_naprawę.Text = "Edytuj naprawę";
            this.button_edytuj_naprawę.UseVisualStyleBackColor = true;
            this.button_edytuj_naprawę.Click += new System.EventHandler(this.button_edytuj_naprawę_Click);
            // 
            // button_usuń_naprawę
            // 
            this.button_usuń_naprawę.Location = new System.Drawing.Point(294, 370);
            this.button_usuń_naprawę.Name = "button_usuń_naprawę";
            this.button_usuń_naprawę.Size = new System.Drawing.Size(118, 23);
            this.button_usuń_naprawę.TabIndex = 3;
            this.button_usuń_naprawę.Text = "Usuń naprawę";
            this.button_usuń_naprawę.UseVisualStyleBackColor = true;
            this.button_usuń_naprawę.Click += new System.EventHandler(this.button_usuń_naprawę_Click);
            // 
            // button_Raport
            // 
            this.button_Raport.Location = new System.Drawing.Point(455, 370);
            this.button_Raport.Name = "button_Raport";
            this.button_Raport.Size = new System.Drawing.Size(104, 23);
            this.button_Raport.TabIndex = 4;
            this.button_Raport.Text = "Raport";
            this.button_Raport.UseVisualStyleBackColor = true;
            this.button_Raport.Click += new System.EventHandler(this.button_Raport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Raport);
            this.Controls.Add(this.button_usuń_naprawę);
            this.Controls.Add(this.button_edytuj_naprawę);
            this.Controls.Add(this.button_dodaj_naprawę);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "StanleyGarage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_dodaj_naprawę;
        private System.Windows.Forms.Button button_edytuj_naprawę;
        private System.Windows.Forms.Button button_usuń_naprawę;
        private System.Windows.Forms.Button button_Raport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

