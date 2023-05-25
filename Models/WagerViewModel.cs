using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class WagerViewModel
    {
        public List<Wager>? Wagers { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
