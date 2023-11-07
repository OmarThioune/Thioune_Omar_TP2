using System.ComponentModel.Design;

namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelArrivee_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerArrivee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {


            if (dateTimePickerArrivee.Value.Month != 7 || dateTimePickerArrivee.Value.Year != dateTimePickerDepart.Value.Year)
            {
                errorProviderDate.SetError(dateTimePickerArrivee, "La date doit être en juillet de la même année");
            }
            else
            {
                if (dateTimePickerArrivee.Value.Day > dateTimePickerDepart.Value.Day)
                {
                    errorProviderDate.SetError(dateTimePickerArrivee, "La date de départ doit être plus tard que la date de l'arrivée");
                }
                else
                {
                    if ((dateTimePickerDepart.Value.Day - dateTimePickerArrivee.Value.Day) > 6)
                    {
                        errorProviderDate.SetError(dateTimePickerArrivee, "il doit y avoir au maximum 6 nuits");
                    }
                    else
                    {
                        errorProviderDate.Clear();
                    }
                }
            }

        }

        private void comboBoxHebergement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxHebergement.SelectedIndex == 0)
            {
                pictureBoxPaysage.Image = Properties.Resources.secteurLac;
            }
            else
            {
                pictureBoxPaysage.Image = Properties.Resources.secteurFleuve;
            }
        }
    }
}