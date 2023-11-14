﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
       public bool validationNom = false;
       public bool validationCourriel = false;
       public bool validationNbAdulte = false;
       public bool validationNbEnfant = false;
       public bool validationTerrain = false;

       public FormReservation()
       {
           InitializeComponent();
       

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


       }

       private void label4_Click(object sender, EventArgs e)
       {

       }

       private void buttonFaireReservation_Click(object sender, EventArgs e)
       {
        
       }

       private void numericUpDownAdulte_ValueChanged(object sender, EventArgs e)
       {
           if (numericUpDownAdulte.Value  > 8)
           {
               errorProviderNbAdulte.SetError(numericUpDownAdulte, "Ce nombre doit etre inférieure à 8");
               validationNbAdulte = false;
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
                validationNbAdulte = false;
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
           string nom = textBoxNom.Text;
           Regex regex = new Regex("^[a-zA-Z\\s'\\-\\x00-\\x1F\\x7F-\\x9F]+$");

           if (textBoxNom.Text == ""  || !regex.IsMatch(nom))
           {
               errorProviderNom.SetError(textBoxNom, "ce champs n'est pas valide");
               validationNom = false;
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
           textBoxCourriel .Text= null;
           textBoxNom.Text = null;
           numericUpDownAdulte.Value = 0;
           numericUpDownEnfants.Value = 0;


           buttonFaireReservation.Enabled = false;

        }
}
