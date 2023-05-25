using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Wager
    {
        public int Id { get; set; }

        //Date
        [Required]
        [Display(Name = "Game Date")]
        [DataType(DataType.Date)]
        public DateTime GameDate { get; set; }
        public DateTime GameDate1 { get; set; }
        public DateTime GameDate2 { get; set; }
        public DateTime GameDate3 { get; set; }
        public DateTime GameDate4 { get; set; }
        //Time
        [Required]
        [Display(Name = "Game Time")]
        [DataType(DataType.Time)]
        public DateTime GameTime { get; set; }
        public DateTime GameTime1 { get; set; }
        public DateTime GameTime2 { get; set; }
        public DateTime GameTime3 { get; set; }
        public DateTime GameTime4 { get; set; }
        //Type
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string? Type { get; set; }
        //Side
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string? Side { get; set; }
        //Odds
        [StringLength(60, MinimumLength = 2)]
        //[Required]
        public string? Odds { get; set; }
        public string? Odds1 { get; set; }
        public string? Odds2 { get; set; }
        public string? Odds3 { get; set; }
        public string? Odds4 { get; set; }
        //DecOdds
        //[Range(1, 100)]
        [DataType(DataType.Text)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DecOdds { get; set; }
        public decimal? DecOdds1 { get; set; }
        public decimal? DecOdds2 { get; set; }
        public decimal? DecOdds3 { get; set; }
        public decimal? DecOdds4 { get; set; }
        //Bet
        //[Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Bet { get; set; }
        //Win
        //[Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Win { get; set; }
        //Payout
        //[Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Payout { get; set; }
        //Leg
        //[StringLength(60, MinimumLength = 1)]
        //[Required]
        public string? Leg1 { get; set; }
        public string? Leg2 { get; set; }
        public string? Leg3 { get; set; }
        public string? Leg4 { get; set; }

        public string? Leg { get; set; }
        //Legs
        public int Legs { get; set; }
        //Winner
        //[StringLength(60, MinimumLength = 2)]
        //[Required]
        public string? Winner { get; set; }
        //Profit
        //[Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Profit { get; set; }
        //Outcome
        public int Outcome { get; set; }
        //Result
        //[StringLength(60, MinimumLength = 2)]
        //[Required]
        public string? Result { get; set; }

        ////Movie
        //[StringLength(60, MinimumLength = 3)]
        //[Required]
        //public string? Title { get; set; }

        //[Display(Name = "Release Date")]
        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }

        //[Range(1, 100)]
        //[DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal Price { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        //[Required]
        //[StringLength(30)]
        //public string? Genre { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        //[StringLength(5)]
        //[Required]
        //public string? Rating { get; set; }
    }
}