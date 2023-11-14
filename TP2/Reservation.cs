using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Reservation
    {
        public int noReservation { get; set; }
        public int noSecteur { get; set; }
        public String nomClient { get; set; }
        public String courriel { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public int nbAdulte { get; set; }
        public int nbEnfant { get; set; }
        public int CoutTotal {  get; set; }

        public Reservation() { }

        public Reservation(int noReservation, int noSecteur, string nomClient, string courriel, DateTime dateDebut, DateTime dateFin, int nbAdulte, int nbEnfant, int coutTotal)
        {
            this.noReservation = noReservation;
            this.noSecteur = noSecteur;
            this.nomClient = nomClient;
            this.courriel = courriel;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.nbAdulte = nbAdulte;
            this.nbEnfant = nbEnfant;
            CoutTotal = coutTotal;
        }

        public override string ToString()
        {
            return "ADULTES : " + nbAdulte + "" +
                "\nEnfants : "+ nbEnfant + "\n Totale personnes : "+(nbAdulte + nbEnfant)+"\n Nombre de nuit : "+(dateFin.Day - dateDebut.Day) + "\n Cout total : "+CoutTotal;
        }
        

        
    }
}
