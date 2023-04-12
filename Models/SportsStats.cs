using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MvcMovie.Model
{
    public partial class SportsStats
    {
        public int Id { get; set; }
        public int leagueId { get; set; }
        public int sportId { get; set; }
        public int teamId { get; set; }
        public string name { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal value { get; set; }

        public string statHash { get; set; }

        public SportsStats(int leagueId, int sportId, int teamId, string name, decimal value, string statHash)
        {
            this.leagueId = leagueId;
            this.sportId = sportId;
            this.teamId = teamId;
            this.name = name;
            this.value = value;
            this.statHash = statHash;
        }

        public SportsStats(string statHash) { this.statHash = statHash; }

        public SportsStats()
        {
            this.Id = Id;
            this.leagueId = leagueId;
            this.sportId = sportId;
            this.teamId = teamId;
            this.name = name;
            this.value = value;
            this.statHash = statHash;
        }
    }
}
