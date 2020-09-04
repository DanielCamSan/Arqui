using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class BasketBall : Sport, IHandSports
    {
        private int NumberOfPlayersPerTeam;
        private int Score;
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Rules { get; set; }

        public BasketBall(string name)
        {
            NumberOfPlayersPerTeam = 5;
            Name = name;
            FoundationDate = new DateTime(1839, 12, 18);
            Rules = "";
        }
        public void AddScore()
        {
            Score = Score + 3;
        }
        public void ExpelAMember()
        {
            NumberOfPlayersPerTeam--;
        }

        public void ChangeMember()
        {
            NumberOfPlayersPerTeam--;
        }
    }
}
