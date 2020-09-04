using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class VolleyBall : Sport, IHandSports
    {
        private int NumberOfPlayersPerTeam;
        private int Score;
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Rules { get; set; }

        public VolleyBall(string name)
        {
            NumberOfPlayersPerTeam = 6;
            Name = name;
            FoundationDate = new DateTime(1839, 12, 18);
            Rules = "";
        }
        public void AddScore()
        {
            Score = Score + 1;
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
