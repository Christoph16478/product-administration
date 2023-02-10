using Produktverwaltung.BusinessLogic;
using Produktverwaltung.Controllers;
using Produktverwaltung.Entities;
using Produktverwaltung.ModelView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produktverwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGrid Aufbereiten
            dgvProdukt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdukt.ReadOnly = true;
            dgvProdukt.SelectionChanged += DgvProdukt_SelectionChanged;

            // Suche beim Tippen
            txtSuchen.KeyUp += TxtSuchen_KeyUp;

            GridViewProduktLaden();
        }

        private void TxtSuchen_KeyUp(object sender, KeyEventArgs e)
        {
            GridViewProduktLaden();
        }

        private void DgvProdukt_SelectionChanged(object sender, EventArgs e)
        {
            int aktuelleZeilenNummer = dgvProdukt.CurrentCell.RowIndex;
            DataGridViewRow aktuelleZeile = dgvProdukt.Rows[aktuelleZeilenNummer];
            int id = int.Parse(aktuelleZeile.Cells[0].Value.ToString());

            FormularProduktLaden(id);

        }

        private void FormularProduktLaden(int id)
        {
            Produkt eintrag = ProduktManager.Get(id);

            if (eintrag != null)
            {
                txtProduktId.Text = eintrag.ProduktId.ToString();
                txtName.Text = eintrag.Name.ToString();
                txtBeschreibung.Text = eintrag.Beschreibung.ToString();
                txtKategorie.Text = eintrag.Kategorie.ToString();

                txtPreisProEinheit.Text = eintrag.PreisProEinheit.ToString();
                txtMengeProEinheit.Text = eintrag.MengeProEinheit.ToString();

                txtEinheitAufLager.Text = eintrag.EinheitAufLager.ToString();
                txtEinheitVorbestellt.Text = eintrag.EinheitVorbestellt.ToString();
                txtNachbestellungsStufe.Text = eintrag.NachbestellungsStufe.ToString();
                txtProduktionEingestellt.Text = eintrag.ProduktionEingestellt.ToString();
            }
        }

        private void GridViewProduktLaden()
        {
            List<Produkt> list = null;

            list = ProduktManager.GetAll();

            string suchBegriff = txtSuchen.Text;
            if (suchBegriff.Length > 0)
            {
                list = list.Where(x =>
                     x.Name.ToLower().Contains(suchBegriff.ToLower()) ||
                     x.Beschreibung.ToLower().Contains(suchBegriff.ToLower()) ||
                     x.Kategorie.ToLower().Contains(suchBegriff.ToLower())
                     ).ToList();
            }

            dgvProdukt.DataSource = list;
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            GridViewProduktLaden();
        }

        private void btnXSuchen_Click(object sender, EventArgs e)
        {
            txtSuchen.Text = "";
            GridViewProduktLaden();
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            FormularPersonNeu();
        }

        private void FormularPersonNeu()
        {
            txtProduktId.Text = "";
            txtName.Text = "";
            txtBeschreibung.Text = "";
            txtKategorie.Text = "";

            txtPreisProEinheit.Text = "";
            txtMengeProEinheit.Text = "";

            txtEinheitAufLager.Text = "";
            txtEinheitVorbestellt.Text = "";
            txtNachbestellungsStufe.Text = "";
            txtProduktionEingestellt.Text = "";
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (txtProduktId.Text != "")
            {
                ProduktAktualisieren();
            }
            else
            {
                ProduktHinzufuegen();
            }
        }


        void ProduktHinzufuegen()
        {
            Produkt eintrag = new Produkt();
            eintrag.Name = txtName.Text;
            eintrag.Beschreibung = txtBeschreibung.Text;
            eintrag.Kategorie = txtKategorie.Text;

            eintrag.PreisProEinheit = float.Parse(txtPreisProEinheit.Text);
            eintrag.MengeProEinheit = int.Parse(txtMengeProEinheit.Text);

            eintrag.EinheitAufLager = int.Parse(txtEinheitAufLager.Text);
            eintrag.EinheitVorbestellt = int.Parse(txtEinheitVorbestellt.Text);
            eintrag.NachbestellungsStufe = int.Parse(txtNachbestellungsStufe.Text);
            eintrag.ProduktionEingestellt = txtProduktionEingestellt.Text;

            int id = ProduktManager.Add(eintrag);
            txtProduktId.Text = id.ToString();

            GridViewProduktLaden();
            WinFormTools.GridViewZeileAuswaehlen(dgvProdukt, 0, id.ToString());
            FormularProduktLaden(id);
        }

        void ProduktAktualisieren()
        {
            int id = int.Parse(txtProduktId.Text);
            Produkt eintrag = ProduktManager.Get(id);
            if (eintrag != null)
            {
                eintrag.Name = txtName.Text;
                eintrag.Beschreibung = txtBeschreibung.Text;
                eintrag.Kategorie = txtKategorie.Text;

                eintrag.PreisProEinheit = float.Parse(txtPreisProEinheit.Text);
                eintrag.MengeProEinheit = int.Parse(txtMengeProEinheit.Text);

                eintrag.EinheitAufLager = int.Parse(txtEinheitAufLager.Text);
                eintrag.EinheitVorbestellt = int.Parse(txtEinheitVorbestellt.Text);
                eintrag.NachbestellungsStufe = int.Parse(txtNachbestellungsStufe.Text);
                eintrag.ProduktionEingestellt = txtProduktionEingestellt.Text;

                int anzahl = ProduktManager.Update(eintrag);
                GridViewProduktLaden();
                WinFormTools.GridViewZeileAuswaehlen(dgvProdukt, 0, id.ToString());
                FormularProduktLaden(id);

            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Sind Sie sicher?", "LÖSCHEN", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                int id = int.Parse(txtProduktId.Text);
                ProduktManager.Delete(id);
                MessageBox.Show("OK. Eintrag gelöscht.");
                GridViewProduktLaden();
            }
            else
            {
                MessageBox.Show("Nicht gelöscht");
            }
        }
    }
}
