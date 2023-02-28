using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanleyGarage
{
    public partial class Form1 : Form
    {
        List<Naprawa> lista_napraw = new List<Naprawa>();
        const string filter = "Pliki naszej aplikacji|*.pna";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = filter;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                FileStream fileStream = new FileStream(openFileDialog.FileName,
                    FileMode.Open, FileAccess.Read);

                List<Mechanik> Mech = (List<Mechanik>)binaryFormatter.Deserialize(fileStream);
                foreach(Mechanik mechanik in Mech)
                {
                    Mechanik.Lista_mechanikow.Add(mechanik);
                }
                List<Naprawa> Nap = (List<Naprawa>)binaryFormatter.Deserialize(fileStream);
                foreach(Naprawa naprawa in Nap)
                {
                    lista_napraw.Add(naprawa);
                }
                fileStream.Close();
                Mechanik.Init();
                odswiez();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać danych.\n" + ex.Message);
            }
            
            Mechanik.Init();
        }
        void odswiez()
        {
            dataGridView1.Rows.Clear();
            foreach (Naprawa naprawa in lista_napraw)
            {
                int index = dataGridView1.Rows.Add(naprawa.Values);
                dataGridView1.Rows[index].Tag = naprawa;
            }
        }

        private void button_dodaj_naprawę_Click(object sender, EventArgs e)
        {
            Naprawa nowa_naprawa = new Naprawa();
            FormNaprawa formNaprawa = new FormNaprawa(nowa_naprawa);
            if (formNaprawa.ShowDialog() == DialogResult.OK)
            {
                lista_napraw.Add(nowa_naprawa);//tu dodajemy naprawę do listy
            }
            odswiez();
        }

        private void button_edytuj_naprawę_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;

            Naprawa naprawa = (Naprawa)dataGridView1.SelectedRows[0].Tag;
            FormNaprawa form = new FormNaprawa(naprawa);
            form.ShowDialog();
            odswiez();
        }

        private void button_usuń_naprawę_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;
            Naprawa naprawa = (Naprawa)dataGridView1.SelectedRows[0].Tag;
            lista_napraw.Remove(naprawa);
            odswiez();
        }

        private void button_Raport_Click(object sender, EventArgs e)
        {
            decimal[] wynagrodzenie = new decimal[Mechanik.Lista_mechanikow.Count];
            decimal suma_należności = 0m;
            string msg = string.Empty;
           

            if (dataGridView1.Rows.Count < 1)
            {
                return;
            }
            foreach (Naprawa naprawa in lista_napraw)
            {
                suma_należności += naprawa.oblicz_należność;
                wynagrodzenie[Mechanik.IndexOf(naprawa.mechanik)]+=naprawa.oblicz_wynagrodzenie;
                
                 


            }
            foreach (Mechanik mechanik in Mechanik.Lista_mechanikow)
            {
                msg += "\n" + "Wynagrodzenie dla: " + mechanik + ": " + wynagrodzenie[Mechanik.Lista_mechanikow.IndexOf(mechanik)].ToString("0.00");
            }
                
            msg += "\nNależności za naprawy : " + suma_należności.ToString("0.00");

            MessageBox.Show(msg, "Raport");

                
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać dane?", "Zamykanie aplikacji",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = filter;
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
                FileStream fileStream = new FileStream(saveFileDialog.FileName,
                    FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                List<Mechanik> Mech = new List<Mechanik>();
                foreach(Mechanik mechanik in Mechanik.Lista_mechanikow)
                {
                    Mech.Add(mechanik);
                }
                binaryFormatter.Serialize(fileStream, Mech);
                List<Naprawa> nap = new List<Naprawa>();
                foreach(Naprawa naprawa in lista_napraw)
                {
                    nap.Add(naprawa);
                }
                binaryFormatter.Serialize(fileStream, nap);
                fileStream.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać danych. " + ex.Message);
            }
            
        }
    }
}
