using Movie_Store_MVC.Controllers.Data;
using System.ComponentModel.DataAnnotations;

namespace Movie_Store_MVC.Models
{
    public class Movie


    {
        [Key]
        public int Id { get; set; }

        public string MovieImageURL { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime Year { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }


    }
}
