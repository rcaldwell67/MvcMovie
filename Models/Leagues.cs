using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MvcMovie.Model
{
    public partial class Leagues
    {
        public int id { get; set; }
        public int sportId { get; set; }
        public int leagueId { get; set; }
        public string sportName { get; set; }
        public string abbreviation { get; set; }
        public string conference { get; set; }
        public string division { get; set; }

        public Leagues(int sportId, int leagueId, string sportName, string abbreviation, string conference, string division)
        {
            this.sportId = sportId;
            this.leagueId = leagueId;
            this.sportName = sportName;
            this.abbreviation = abbreviation;
            this.conference = conference;
            this.division = division;
        }

        public Leagues()
        {
            id = id;
            sportId = sportId;
            leagueId = leagueId;
            sportName = sportName;
            abbreviation = abbreviation;
            conference = conference;
            division = division;
        }
    }
}
