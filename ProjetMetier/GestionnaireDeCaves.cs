﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            // A vous de jouer

            lesCaves.Add(unNomDeCave, lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            // A vous de jouer
            return lesCaves[unNomDeCave].Count;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            // A vous de jouer

            int NbBouteilles = 0;
            foreach (Bouteille b in lesCaves[unNomDeCave])
            {
                if (b.LeVin.LaCouleur.NomCouleur == "Rouge")
                {
                     NbBouteilles++;
                }
                
            }
            return NbBouteilles;

        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            // A vous de jouer

            double Prix = 0;
            foreach (Bouteille b in LesCaves[unNomDeCave])
            {
               Prix += b.QuantiteBouteille * b.LeVin.PrixDuVin;
            }
            return Prix;
            
        }
    }
}
