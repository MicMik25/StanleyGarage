
namespace StanleyGarage
{
    partial class FormNaprawa
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nazwa_naprawy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_numer_rejestracyjny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_koszt_czesci = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_czas_pracy = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_koszt_czesci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_czas_pracy)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mechanik :";
            // 
            // textBox_nazwa_naprawy
            // 
            this.textBox_nazwa_naprawy.Location = new System.Drawing.Point(12, 98);
            this.textBox_nazwa_naprawy.Name = "textBox_nazwa_naprawy";
            this.textBox_nazwa_naprawy.Size = new System.Drawing.Size(121, 20);
            this.textBox_nazwa_naprawy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa naprawy:";
            // 
            // textBox_numer_rejestracyjny
            // 
            this.textBox_numer_rejestracyjny.Location = new System.Drawing.Point(12, 152);
            this.textBox_numer_rejestracyjny.Name = "textBox_numer_rejestracyjny";
            this.textBox_numer_rejestracyjny.Size = new System.Drawing.Size(119, 20);
            this.textBox_numer_rejestracyjny.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numer rejestracyjny :";
            // 
            // numericUpDown_koszt_czesci
            // 
            this.numericUpDown_koszt_czesci.Location = new System.Drawing.Point(11, 206);
            this.numericUpDown_koszt_czesci.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_koszt_czesci.Name = "numericUpDown_koszt_czesci";
            this.numericUpDown_koszt_czesci.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_koszt_czesci.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Koszt części :";
            // 
            // numericUpDown_czas_pracy
            // 
            this.numericUpDown_czas_pracy.Location = new System.Drawing.Point(11, 259);
            this.numericUpDown_czas_pracy.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_czas_pracy.Name = "numericUpDown_czas_pracy";
            this.numericUpDown_czas_pracy.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_czas_pracy.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Czas pracy :";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(11, 317);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 10;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.Location = new System.Drawing.Point(130, 317);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(75, 23);
            this.button_anuluj.TabIndex = 11;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data przyjęcia do naprawy :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // FormNaprawa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 389);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_czas_pracy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_koszt_czesci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_numer_rejestracyjny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nazwa_naprawy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormNaprawa";
            this.Text = "Informacje o naprawie";
            this.Load += new System.EventHandler(this.FormNaprawa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_koszt_czesci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_czas_pracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nazwa_naprawy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_numer_rejestracyjny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_koszt_czesci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_czas_pracy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}