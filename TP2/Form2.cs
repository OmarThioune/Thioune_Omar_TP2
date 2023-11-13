using System;
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
}
