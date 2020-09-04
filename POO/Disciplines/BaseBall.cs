using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class BaseBall: Sport , IToolSports
    {
        private int NumberOfPlayersPerTeam;
        private int NumberOfTools;
        private int Score;
        public string Name { get; set; }
        private  DateTime FoundationDate { get; set; }
        public string Rules { get; set; }

        public BaseBall(string name)
        {
            NumberOfPlayersPerTeam = 9;
            Name = name;
            FoundationDate= new DateTime(1839, 12, 18);
            Rules = "";
        }
        public void AddScore()
        {
            Score++;
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
