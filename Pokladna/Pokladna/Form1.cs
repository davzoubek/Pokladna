using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
    public partial class Form1 : Form
    {
        List<PokladniZaznam> pokladna;
        IRepos repositar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonRepos jsonRepos = new JsonRepos("data.json");
            //jsonRepos.VytvorTestData();
            repositar = jsonRepos;
            cBoxRok.SelectedIndex = cBoxRok.Items.IndexOf(DateTime.Now.Year.ToString());
            cBoxMesic.SelectedIndex = DateTime.Now.Month-1;
            //repositar = new SqlRepos();
            //repositar = new XmlRepos();
            //pokladna = repositar.NactiVse();
            //foreach (var p in pokladna)
            //{
            //  listViewData.Items.Add(p.DolvItem());
            // }
        }

        private void CBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            NactiAktMesic();
            
        }
        private void NactiAktMesic()
        {
            if (cBoxRok.SelectedIndex >= 0 && cBoxMesic.SelectedIndex >= 0)
            {
                pokladna = repositar.NactiMesic(int.Parse(cBoxRok.SelectedText), cBoxMesic.SelectedIndex + 1);
                foreach (var p in pokladna)
                {
                    listViewData.Items.Add(p.DolvItem());
                }
            }
        }

        private void CBoxMesic_SelectedIndexChanged(object sender, EventArgs e)
        {
            NactiAktMesic();
        }

        private void DokladTextBox_TextChanged(object sender, EventArgs e)
        {
            ulozitButton.Enabled = dokladTextBox.Text != "";
        }

        private void PopisTextBox_TextChanged(object sender, EventArgs e)
        {
            ulozitjakoButton.Enabled = popisTextBox.Text.Trim() != "" && castkaNumericUpDown.Value != 0;
        }

        private void UlozitjakoButton_Click(object sender, EventArgs e)
        {
            PokladniZaznam novyzaznam = new PokladniZaznam(datumDateTimePicker.Value, popisTextBox.Text, (double)castkaNumericUpDown.Value, poznamkaTextBox.Text);

            repositar.VytvorZaznam(novyzaznam);
            NactiAktMesic();
            popisTextBox.Text = "";
            castkaNumericUpDown.Value = 0;
            poznamkaTextBox.Text = "";
        }
    }
}
