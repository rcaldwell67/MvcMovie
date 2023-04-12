using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Model
{
    public class SportsBooks
    {
        #region Constructors  
        public SportsBooks() { }
        #endregion
        #region Private Fields  
        private int _id;
        private string _Name;
        private string _Url;
        private bool _IsActive;
        #endregion
        #region Public Properties  
        public int id { get { return _id; } set { _id = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Url { get { return _Url; } set { _Url = value; } }
        public bool IsActive { get { return _IsActive; } set { _IsActive = value; } }
        #endregion  
    }

    public enum SportBook
    {
        Bovada,
        FiveDimes,
        Intertops,
        Nitrogen,
        Sportbet,
        Sportsbetting
    }
}
 