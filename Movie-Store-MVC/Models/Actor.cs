using System.ComponentModel.DataAnnotations;

namespace Movie_Store_MVC.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string IdPictureUrl { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set;}
    }
}
