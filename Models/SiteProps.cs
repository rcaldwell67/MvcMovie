using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Model
{
    public class SiteProps //: IEnumerable
    {
        #region Constructors  
        public SiteProps() { }
        #endregion
        #region Private Fields  
        private int _id;
        private string _userId;
        private int? _WinStreak;
        private int? _LoseStreak;
        #endregion
        #region Public Properties  
        public int id { get { return _id; } set { _id = value; } }
        public string userId { get { return _userId; } set { _userId = value; } }

        [Display(Name = "Win Streak")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        //[Column(TypeName = "decimal(18,0)")]
        public int? WinStreak { get { return _WinStreak; } set { _WinStreak = value; } }

        [Display(Name = "Lose Streak")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        //[Column(TypeName = "decimal(18,0)")]
        public int? LoseStreak { get { return _LoseStreak; } set { _LoseStreak = value; } }
        #endregion
        #region IEnumerable
        //List<SiteProps> siteProps;

        //public IEnumerator<SiteProps> GetEnumerator()
        //{
        //    foreach (var siteProp in siteProps)
        //        yield return siteProp;
        //}

        ////public IEnumerator IEnumberable.GetEnumerator()
        ////{
        ////    return siteProp.GetEnumerator();
        ////}

        ////This method is also needed, but usually you don't need to change it from this.
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
        #endregion
    
    }
   
    public enum WinStreaks
    {
        one = 1,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten
    }

    public enum LoseStreaks
    {
        one = -1,
        two = -2,
        three = -3,
        four = -4,
        five = -5,
        six = -6,
        seven = -7,
        eight = -8,
        nine = -9,
        ten = -10
    }
}

