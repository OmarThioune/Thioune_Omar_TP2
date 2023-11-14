using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Camping
    {

        public int NoCamping {  get; set; }
        public String NomCamping { get; set; }
        public int NoTerrain { get; set; }
        public int CoutAdulte {  get; set; }
        public int CoutEnfant { get; set; }
        public String image {  get; set; } 
        public String nomFichier { get; set; }

        public Camping() { }

        public Camping (int _noCamping, string _nomCamping, int _noTerrain, int _coutAdulte, int _coutEnfant, string _image, string _nomFichier)
        {
            NoCamping = _noCamping;
            NomCamping = _nomCamping;
            NoTerrain = _noTerrain;
            CoutAdulte = _coutAdulte;
            CoutEnfant = _coutEnfant;
            image = _image;
            nomFichier = _nomFichier;
        }
    }
}
