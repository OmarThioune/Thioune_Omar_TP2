using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MaxNuit = 6;
        const String messageErreur = "La date doit être en juillet de la même année";
        const String messageErreur2 = "La date de départ doit être plus tard que la date de l'arrivée";
        const String messageErreur3 = "il doit y avoir au maximum 6 nuits";

        private void buttonReservation_Click(object sender, EventArgs e)
        {


            if (dateTimePickerArrivee.Value.Month != 7 || dateTimePickerArrivee.Value.Year != dateTimePickerDepart.Value.Year)
            {
                errorProviderDate.SetError(dateTimePickerArrivee, messageErreur);
            }
            else
            {
                if (dateTimePickerArrivee.Value.Day > dateTimePickerDepart.Value.Day)
                {
                    errorProviderDate.SetError(dateTimePickerArrivee, messageErreur2);
                }
                else
                {
                    if ((dateTimePickerDepart.Value.Day - dateTimePickerArrivee.Value.Day) > MaxNuit)
                    {
                        errorProviderDate.SetError(dateTimePickerArrivee, messageErreur3);
                    }
                    else
                    {
                        if (comboBoxHebergement.Text != "Choix des hébergements" || dateTimePickerArrivee.Value != dateTimePickerDepart.Value)
                        {
                            errorProviderDate.Clear();
                            FormReservation fenetre = new FormReservation();
                            

                            if (comboBoxHebergement.Text == "Secteur du Lac")
                            {
                                Camping camp = new Camping(0, comboBoxHebergement.Text, 8, 20, 5, "Lac", "RESERV_LAC");
                                fenetre.Affichage(camp);

                            }
                            else
                            {
                                Camping camp = new Camping(1, comboBoxHebergement.Text, 4, 15, 0, "fleuve", "RESERV_FLEUVE");
                                fenetre.Affichage(camp);
                            }
                            fenetre.LesDate(dateTimePickerArrivee.Value, dateTimePickerDepart.Value);
                            
                            fenetre.ShowDialog();
                            
                        }
                    }
                }
            }

        }

        private void comboBoxHebergement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHebergement.SelectedIndex == 0)
            {
                pictureBoxPaysage.Image = Properties.Resources.secteurLac;
            }
            else
            {
                pictureBoxPaysage.Image = Properties.Resources.secteurFleuve;
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
