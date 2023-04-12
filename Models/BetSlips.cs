using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Model
{
    public class BetSlips
    {
        #region Constructors  
        public BetSlips() { }
        #endregion
        #region Private Fields  
        private int _id;
        private string _userId;
        private int _teamId;
        private int _sportId;
        private int _leagueId;
        private string _location;
        private string _name;
        private string _abbreviation;
        private string _displayName;
        private bool _isActive;
        private decimal? _avgPointsAgainst;
        private decimal? _avgPointsFor;
        private decimal? _gamesBehind;
        private decimal? _gamesPlayed;
        private decimal? _gamesLeft;
        private decimal? _homeLosses;
        private decimal? _homeTies;
        private decimal? _homeWins;
        private decimal? _leagueWinPercent;
        private decimal? _losses;
        private decimal? _OTWins;
        private decimal? _OTLosses;
        private decimal? _playoffSeed;
        private decimal? _pointDifferential;
        private decimal? _pointsAgainst;
        private decimal? _pointsDiff;
        private decimal? _pointsFor;
        private decimal? _roadLosses;
        private decimal? _roadTies;
        private decimal? _roadWins;
        private decimal? _rotWins;
        private decimal? _streak;
        private decimal? _ties;
        private decimal? _winPercent;
        private decimal? _wins;
        private string _statHash;
        private decimal? _winPct;
        private string _sportsBook;
        private string _opponent;
        private string _oddsFave;
        private decimal _wagerFave;
        private string _oddsUD;
        private decimal _wagerUD;
        private DateTime _betslipDateTime;
        private string _betslipHash;
        private decimal _profitUD;
        private decimal _profitFave;
        private decimal _totalProfitUD;
        private decimal _totalProfitFave;
        private decimal _totalProfit;
        #endregion
        #region Public Properties  
        public int id { get { return _id; } set { _id = value; } }
        public string userId { get { return _userId; } set { _userId = value; } }
        public int teamId { get { return _teamId; } set { _teamId = value; } }
        public int sportId { get { return _sportId; } set { _sportId = value; } }
        public int leagueId { get { return _leagueId; } set { _leagueId = value; } }
        public string location { get { return _location; } set { _location = value; } }
        public string name { get { return _name; } set { _name = value; } }

        [Display(Name = "Team")]
        public string abbreviation { get { return _abbreviation; } set { _abbreviation = value; } }

        [Display(Name = "Team")]
        public string displayName { get { return _displayName; } set { _displayName = value; } }

        public bool isActive { get { return _isActive; } set { _isActive = value; } }

        [Display(Name = "Avg Points Against")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? avgPointsAgainst { get { return _avgPointsAgainst; } set { _avgPointsAgainst = value; } }

        [Display(Name = "Avg Points For")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? avgPointsFor { get { return _avgPointsFor; } set { _avgPointsFor = value; } }

        [Display(Name = "Games Behind")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? gamesBehind { get { return _gamesBehind; } set { _gamesBehind = value; } }

        [Display(Name = "Games Played")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? gamesPlayed { get { return _gamesPlayed; } set { _gamesPlayed = value; } }

        [Display(Name = "Games Left")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? gamesLeft { get { return _gamesLeft; } set { _gamesLeft = value; } }

        [Display(Name = "Home Losses")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? homeLosses { get { return _homeLosses; } set { _homeLosses = value; } }

        [Display(Name = "Home Ties")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? homeTies { get { return _homeTies; } set { _homeTies = value; } }

        [Display(Name = "Home Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? homeWins { get { return _homeWins; } set { _homeWins = value; } }

        [Display(Name = "League Win%")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? leagueWinPercent { get { return _leagueWinPercent; } set { _leagueWinPercent = value; } }

        [Display(Name = "Losses")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? losses { get { return _losses; } set { _losses = value; } }

        [Display(Name = "OT Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? OTWins { get { return _OTWins; } set { _OTWins = value; } }

        [Display(Name = "OT Losses")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? OTLosses { get { return _OTLosses; } set { _OTLosses = value; } }

        [Display(Name = "Playoff Seed")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? playoffSeed { get { return _playoffSeed; } set { _playoffSeed = value; } }

        [Display(Name = "Pts Diff")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? pointDifferential { get { return _pointDifferential; } set { _pointDifferential = value; } }

        [Display(Name = "Pts Against")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? pointsAgainst { get { return _pointsAgainst; } set { _pointsAgainst = value; } }

        [Display(Name = "Points Diff")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? pointsDiff { get { return _pointsDiff; } set { _pointsDiff = value; } }

        [Display(Name = "Pts For")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? pointsFor { get { return _pointsFor; } set { _pointsFor = value; } }

        [Display(Name = "Road Losses")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? roadLosses { get { return _roadLosses; } set { _roadLosses = value; } }

        [Display(Name = "Road Ties")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? roadTies { get { return _roadTies; } set { _roadTies = value; } }

        [Display(Name = "Road Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? roadWins { get { return _roadWins; } set { _roadWins = value; } }

        [Display(Name = "Road OT Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? rotWins { get { return _rotWins; } set { _rotWins = value; } }

        [Display(Name = "Streak")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? streak { get { return _streak; } set { _streak = value; } }

        [Display(Name = "Ties")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? ties { get { return _ties; } set { _ties = value; } }

        [Display(Name = "Win%")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? winPercent { get { return _winPercent; } set { _winPercent = value; } }

        [Display(Name = "Wins")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal? wins { get { return _wins; } set { _wins = value; } }

        public string statHash { get { return _statHash; } set { _statHash = value; } }

        [Display(Name = "Win%")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? winPct { get { return _winPct; } set { _winPct = value; } }

        [Display(Name = "Sports Book")]
        public string sportsBook { get { return _sportsBook; } set { _sportsBook = value; } }

        [Display(Name = "Opp")]
        public string opponent { get { return _opponent; } set { _opponent = value; } }

        [Display(Name = "Odds Fave")]
        public string oddsFave { get { return _oddsFave; } set { _oddsFave = value; } }

        [Display(Name = "Wager Fave")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal wagerFave { get { return _wagerFave; } set { _wagerFave = value; } }

        [Display(Name = "Odds UD")]
        public string oddsUD { get { return _oddsUD; } set { _oddsUD = value; } }

        [Display(Name = "Wager UD")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal wagerUD { get { return _wagerUD; } set { _wagerUD = value; } }

        [Display(Name = "Bet Date")]
        public DateTime betslipDateTime { get { return _betslipDateTime; } set { _betslipDateTime = value; } }

        public string betslipHash { get { return _betslipHash; } set { _betslipHash = value; } }

        [Display(Name = "Profit UD")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal profitUD { get { return _profitUD; } set { _profitUD = value; } }

        [Display(Name = "Profit Fave")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal profitFave { get { return _profitFave; } set { _profitFave = value; } }

        [Display(Name = "Total Profit UD")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal totalProfitUD { get { return _totalProfitUD; } set { _totalProfitUD = value; } }

        [Display(Name = "Total Profit Fave")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal totalProfitFave { get { return _totalProfitFave; } set { _totalProfitFave = value; } }

        [Display(Name = "Total Profit")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal totalProfit { get { return _totalProfit; } set { _totalProfit = value; } }
        #endregion

    }
}
