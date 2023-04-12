using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MvcMovie.Model
{
    public partial class Teams
    {
        public int id { get; set; }
        public int teamId { get; set; }
        public int sportId { get; set; }
        public int leagueId { get; set; }
        public string location { get; set; }
        public string name { get; set; }

        [Display(Name = "Team")]
        public string abbreviation { get; set; }

        [Display(Name = "Team")]
        public string displayName { get; set; }

        public bool isActive { get; set; }

        [Display(Name = "Avg Points Against")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? avgPointsAgainst { get; set; }

        [Display(Name = "Avg Points For")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? avgPointsFor { get; set; }

        [Display(Name = "Games Behind")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? gamesBehind { get; set; }

        [Display(Name = "Games Played")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? gamesPlayed { get; set; }

        [Display(Name = "Games Left")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? gamesLeft { get; set; }

        [Display(Name = "Home Losses")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? homeLosses { get; set; }

        [Display(Name = "Home Ties")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? homeTies { get; set; }

        [Display(Name = "Home Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? homeWins { get; set; }

        [Display(Name = "League Win%")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? leagueWinPercent { get; set; }

        [Display(Name = "Losses")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? losses { get; set; }

        [Display(Name = "OT Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? OTWins { get; set; }

        [Display(Name = "OT Losses")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? OTLosses { get; set; }

        [Display(Name = "Playoff Seed")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? playoffSeed { get; set; }

        [Display(Name = "Pts Diff")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? pointDifferential { get; set; }

        [Display(Name = "Pts Against")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? pointsAgainst { get; set; }

        [Display(Name = "Points Diff")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? pointsDiff { get; set; }

        [Display(Name = "Pts For")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? pointsFor { get; set; }

        [Display(Name = "Road Losses")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? roadLosses { get; set; }

        [Display(Name = "Road Ties")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? roadTies { get; set; }

        [Display(Name = "Road Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? roadWins { get; set; }

        [Display(Name = "Road OT Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? rotWins { get; set; }

        [Display(Name = "Streak")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? streak { get; set; }

        [Display(Name = "Ties")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? ties { get; set; }

        [Display(Name = "Win%")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? winPercent { get; set; }

        [Display(Name = "Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? wins { get; set; }

        // public string? statHash { get; set; }
        public string statHash { get; set; }

        [Display(Name = "Win%")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? winPct { get; set; }

        public Teams(int teamId, int sportId, int leagueId, string location, string name, string abbreviation, string displayName, bool isActive)
        {
            this.teamId = teamId;
            this.sportId = sportId;
            this.leagueId = leagueId;
            this.location = location;
            this.name = name;
            this.abbreviation = abbreviation;
            this.displayName = displayName;
            this.isActive = isActive;

        }

        public Teams()
        {
            id = id;
            teamId = teamId;
            sportId = sportId;
            location = location;
            name = name;
            abbreviation = abbreviation;
            displayName = displayName;
            isActive = isActive;
            avgPointsAgainst = avgPointsAgainst;
            avgPointsFor = avgPointsFor;
            gamesBehind = gamesBehind;
            gamesPlayed = gamesPlayed;
            homeLosses = homeLosses;
            homeTies = homeTies;
            homeWins = homeWins;
            leagueWinPercent = leagueWinPercent;
            losses = losses;
            OTLosses = OTLosses;
            OTWins = OTWins;
            playoffSeed = playoffSeed;
            pointDifferential = pointDifferential;
            pointsAgainst = pointsAgainst;
            pointsDiff = pointsDiff;
            pointsFor = pointsFor;
            roadLosses = roadLosses;
            roadTies = roadTies;
            roadWins = roadWins;
            rotWins = rotWins;
            streak = streak;
            ties = ties;
            winPercent = winPercent;
            wins = wins;
            statHash = statHash;
        }
    }
}
