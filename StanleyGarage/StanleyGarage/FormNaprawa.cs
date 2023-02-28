using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanleyGarage
{
    
    public partial class FormNaprawa : Form
    {
        Naprawa naprawa;
        
        
        

        internal FormNaprawa(Naprawa naprawa)
        {
            this.naprawa = naprawa;
            InitializeComponent();
            
            

            button_OK.DialogResult = DialogResult.OK;
            button_anuluj.DialogResult = DialogResult.Cancel;
        }

        private void FormNaprawa_Load(object sender, EventArgs e)
        {
            
            if (comboBox1.Items.Count == 0)
            {
                foreach (Mechanik mechanik in Mechanik.Lista_mechanikow)
                {

                    comboBox1.Items.Add(mechanik);
                }
            }
            else
                return;
           


            //po to zeby w edycji było widać już wprowadzone dane
            textBox_nazwa_naprawy.Text = naprawa.nazwa_naprawy;
            textBox_numer_rejestracyjny.Text = naprawa.numer_rejestracyjny;
            numericUpDown_koszt_czesci.Value = naprawa.koszt_uzytych_czesci;
            numericUpDown_czas_pracy.Value = naprawa.czas_pracy_mechanika;
            
            
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            naprawa.nazwa_naprawy = textBox_nazwa_naprawy.Text;
            naprawa.numer_rejestracyjny = textBox_numer_rejestracyjny.Text;
            naprawa.koszt_uzytych_czesci = numericUpDown_koszt_czesci.Value;
            naprawa.czas_pracy_mechanika = numericUpDown_czas_pracy.Value;
            
            {
                naprawa.mechanik =(Mechanik)comboBox1.SelectedItem;
            }
          
            
            
            naprawa.data_oddania_do_naprawy =dateTimePicker1.Value;

        }
    }
}
