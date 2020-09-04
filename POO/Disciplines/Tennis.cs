using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Tennis : Sport, IToolSports
    {
        private int NumberOfPlayersPerTeam;
        private int NumberOfTools;
        private int Score;
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Rules { get; set; }

        public Tennis(string name)
        {

            NumberOfPlayersPerTeam = 2;
            Name = name;
            FoundationDate = new DateTime(1839, 12, 18);
            Rules = "";
        }
        public void AddScore()
        {
            Score=Score+15;
        }
        public void ExpelAMember()
        {
            NumberOfPlayersPerTeam--;
        }

        public void ChangeTool()
        {
            NumberOfTools--;
        }
    }
}
