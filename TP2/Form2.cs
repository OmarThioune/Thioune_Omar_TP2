using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP2
{
    public partial class FormReservation : Form
    {

        public bool validationNom = false;
        public bool validationCourriel = false;
        public bool validationNbAdulte = false;
        public bool validationNbEnfant = true;
        public bool validationTerrain = false;
        public String chemin = Application.StartupPath + "\\";
        public String nomFichier;
        const int nbTerrains = 8;
        const int nbJours = 31;
        bool[,] CampingDispo = new bool[nbTerrains, nbJours];
        DateTime JourDebut, JourFin;
        public int Compteur = 0;
        int coutAdulte;
        int coutEnfant;
        int nbNuit;
        int noCamping;




        public FormReservation()
        {
            InitializeComponent();

            for (int i = 0; i < nbTerrains; i++)
            {
                for (int j = 0; j < nbJours; j++)
                {
                    CampingDispo[i, j] = false;
                }
            }


        }

        internal void LesDate (DateTime arrive , DateTime depart)
        {
            JourDebut = arrive;
            JourFin = depart;
        }
 

        internal void Affichage(Camping camp)
        {

            if (camp.image == "Lac")
            {
                pictureBoxPaysage2.Image = Properties.Resources.secteurLac;
                textBoxTerrain5.Visible = true;
                textBoxTerrain6.Visible = true;
                textBoxTerrain7.Visible = true;
                textBoxTerrain8.Visible = true;
                comboBoxChoixTerrain.Items.Add("T5");
                comboBoxChoixTerrain.Items.Add("T6");
                comboBoxChoixTerrain.Items.Add("T7");
                comboBoxChoixTerrain.Items.Add("T8");
            }
            else
            {
                pictureBoxPaysage2.Image = Properties.Resources.secteurFleuve;
            }

            label_nomCamping.Text = camp.NomCamping;
            nomFichier = camp.nomFichier;


            noCamping = camp.NoCamping;
            

            coutAdulte = camp.CoutAdulte;
            coutEnfant = camp.CoutEnfant;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonFaireReservation_Click(object sender, EventArgs e)
        {


            if (comboBoxChoixTerrain.SelectedIndex != -1)
            {
                if (JourDebut.Day < JourFin.Day)
                {
                    for (int ctr = JourDebut.Day; ctr < JourFin.Day; ctr++)
                    {
                        CampingDispo[comboBoxChoixTerrain.SelectedIndex, ctr] = true;

                    }
                }
            }

            int CoutTotal = coutEnfant * (int)numericUpDownEnfants.Value + coutAdulte * (int)numericUpDownAdulte.Value;
            Reservation Reserve = new Reservation(Compteur, noCamping, textBoxNom.Text, textBoxCourriel.Text, JourDebut, JourFin, (int)numericUpDownAdulte.Value, (int)numericUpDownEnfants.Value, CoutTotal);


            listBoxFacture.Items.Add(Reserve.ToString());

            try
            {
                StreamWriter ecriture = new StreamWriter(chemin + nomFichier, false);
                ecriture.WriteLine(Compteur + noCamping + textBoxNom.Text + textBoxCourriel.Text + JourDebut + JourFin + (int)numericUpDownAdulte.Value + (int)numericUpDownEnfants.Value + CoutTotal + ";\n\r");
                ecriture.Close();
                MessageBox.Show("Le fichier " + nomFichier + " est sauvegardé.",
                    "Écriture d'un fichier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);

            }

            Compteur++;

            if (JourDebut < JourFin)
            {
                for (int ctr = JourDebut.Day; ctr < JourFin.Day; ctr++)
                {
           
                    if (CampingDispo[0, ctr])
                    {
                        textBoxTerrain1.BackColor = Color.Red;
                    }
                    if (CampingDispo[1, ctr])
                    {
                        textBoxTerrain2.BackColor = Color.Red;
                    }
                    if (CampingDispo[2, ctr])
                    {
                        textBoxTerrain3.BackColor = Color.Red;
                    }
                    if (CampingDispo[3, ctr])
                    {
                        textBoxTerrain4.BackColor = Color.Red;
                    }
                    if (CampingDispo[4, ctr])
                    {
                        textBoxTerrain5.BackColor = Color.Red;
                    }
                    if (CampingDispo[5, ctr])
                    {
                        textBoxTerrain6.BackColor = Color.Red;
                    }
                    if (CampingDispo[6, ctr])
                    {
                        textBoxTerrain7.BackColor = Color.Red;
                    }
                    if (CampingDispo[7, ctr])
                    {
                        textBoxTerrain8.BackColor = Color.Red;
                    }
                }
            }
        }

        private void numericUpDownAdulte_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownAdulte.Value > 8 || numericUpDownAdulte.Value < 0)
            {
                errorProviderNbAdulte.SetError(numericUpDownAdulte, "Ce nombre doit etre inférieure à 8 et plus grand que 0");
                validationNbAdulte = false;
                buttonFaireReservation.Enabled = false;
            }
            else
            {
                errorProviderNbAdulte.Clear();
                validationNbAdulte = true;

            }

            if (validationNbAdulte == true && validationNbEnfant == true &&
                validationCourriel == true && validationNom == true && validationTerrain == true
                )
            {
                buttonFaireReservation.Enabled = true;

            }

        }

        private void numericUpDownEnfants_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownEnfants.Value > 8)
            {
                errorProviderNbEnfant.SetError(numericUpDownEnfants, "Ce nombre doit etre inférieure à 8");
                validationNbEnfant = false;
                buttonFaireReservation.Enabled = false;
            }
            else
            {
                errorProviderNbEnfant.Clear();
                validationNbEnfant = true;

            }

            if (validationNbAdulte == true && validationNbEnfant == true &&
                validationCourriel == true && validationNom == true && validationTerrain == true
                )
            {
                buttonFaireReservation.Enabled = true;

            }

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

            Regex regex = new Regex("^[a-zA-Z\\s'\\-\\x00-\\x1F\\x7F-\\x9F]+$");

            if (textBoxNom.Text == "" || !regex.IsMatch(textBoxNom.Text))
            {
                errorProviderNom.SetError(textBoxNom, "ce champs n'est pas valide");
                validationNom = false;
                buttonFaireReservation.Enabled = false;
            }
            else
            {
                errorProviderNom.Clear();
                validationNom = true;
            }

            if (validationNbAdulte == true && validationNbEnfant == true &&
                validationCourriel == true && validationNom == true && validationTerrain == true
            )
            {
                buttonFaireReservation.Enabled = true;

            }
        }

        private void textBoxCourriel_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCourriel.Text == "" || !textBoxCourriel.Text.Contains("@"))
            {
                errorProviderCourriel.SetError(textBoxCourriel, "Ce champs n'est pas valide");
                validationCourriel = false;
                buttonFaireReservation.Enabled = false;
            }
            else
            {
                errorProviderCourriel.Clear();
                validationCourriel = true;
            }

            if (validationNbAdulte == true && validationNbEnfant == true &&
                 validationCourriel == true && validationNom == true && validationTerrain == true
)
            {
                buttonFaireReservation.Enabled = true;

            }
        }

        private void comboBoxChoixTerrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoixTerrain.Text == "")
            {
                errorProviderChoixTerrain.SetError(comboBoxChoixTerrain, "Ce champs doit etre rempli");
                validationTerrain = false;
                buttonFaireReservation.Enabled = false;
            }
            else
            {
                errorProviderChoixTerrain.Clear();
                validationTerrain = true;
            }

            if (validationNbAdulte == true && validationNbEnfant == true &&
                validationCourriel == true && validationNom == true && validationTerrain == true
)
            {
                buttonFaireReservation.Enabled = true;

            }
        }

        private void buttonNouvelleReservation_Click(object sender, EventArgs e)
        {
            textBoxCourriel.Text = null;
            textBoxNom.Text = null;
            numericUpDownAdulte.Value = 0;
            numericUpDownEnfants.Value = 0;


            buttonFaireReservation.Enabled = false;

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
