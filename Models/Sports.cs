using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MvcMovie.Model
{
    public partial class Sports
    {

        #region Constructors  
        //public Sports() { }
        
        public Sports(int sportId, int leagueId, string sportName, string abbreviation, string API_URL, string XML_FileName)
        {
            this.sportId = sportId;
            this.leagueId = leagueId;
            this.sportName = sportName;
            this.abbreviation = abbreviation;
            this.API_URL = API_URL;
            this.XML_FileName = XML_FileName;
        }

        public Sports(string API_URL, string XML_FileName)
        {
            this.API_URL = API_URL;
            this.XML_FileName = XML_FileName;
        }

        public Sports()
        {
            id = id;
            sportId = sportId;
            leagueId = leagueId;
            sportName = sportName;
            abbreviation = abbreviation;
            API_URL = API_URL;
            XML_FileName = XML_FileName;
            totalGames = totalGames;
        }
        #endregion
        #region Private Fields  
        private int _id;
        private int _sportId;
        private int _leagueId;
        private string _sportName;
        private string _abbreviation;
        private string _API_URL;
        private string _XML_FileName;
        private int _totalGames;
        private bool _IsActive;
        #endregion
        #region Public Properties
        public int id { get { return _id; } set { _id = value; } }
        public int sportId { get { return _sportId; } set { _sportId = value; } }
        public int leagueId { get { return _leagueId; } set { _leagueId = value; } }
        public string sportName { get { return _sportName; } set { _sportName = value; } }
        public string abbreviation { get { return _abbreviation; } set { _abbreviation  = value; } }
        public string API_URL { get { return _API_URL; } set { _API_URL = value; } }
        public string XML_FileName { get { return _XML_FileName; } set { _XML_FileName = value; } }
        public int totalGames { get { return _totalGames; } set { _totalGames = value; } }
        public bool IsActive { get { return _IsActive; } set { _IsActive = value; } }
        #endregion

    }

    public enum Sport
    {
        MLB = 1,
        NBA,
        NFL,
        NHL,
        NCAAM
    }

}
