namespace FightingGameTuto
{
    class Warrior
    {
        #region Champs de classe combattant
        // Nom du combattant
        private string Name { get; set; }
        // Point de vie du combattant
        private int PV { get; set; }
        // Force d'attaque du combattant
        private int Attaque { get; set; }
        // Capacité de garde du combattant
        private int Garde { get; set; }
        //Score de dé
        private int ScoreDe { get; set; }
        #endregion

        #region Constructeurs Combattants
        public Warrior(string name, int pv, int attaque, int garde)
        {
            this.Name = name;
            this.PV = pv;
            this.Attaque = attaque;
            this.Garde = garde;
        }
        #endregion

        #region Methode de classe Warrior

        /// <summary>
        /// Methode qui fait s'attaquer les combattants à tour de rôle jusqu'a ce qu'un des combattant n'ait plus de PV
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        public void SartFight(Warrior player1, Warrior player2)
        {

            while (player1.PV > 0 & player2.PV > 0)
            {
                //lancé de dé pour déterminer quel joueur attaque en 1er

                //Determiner la puissance d'attaque et de blocage du joueur 1 pour ce tours

                //Determiner la puissance d'attaque et de blocage du joueur 2 pour ce tours

                //calcul des dégats subit par le joueur n'ayant pas l'initiative (attaque * lancé de dé - blocage*lancé de dé)
            }
        }


        #endregion



    }
}
