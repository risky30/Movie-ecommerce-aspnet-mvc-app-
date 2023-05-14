using System.ComponentModel.DataAnnotations;

namespace eTicketsProject.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string? Logo { get; set; }
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }

        //Relationships ; cinema can have a list of movies
        public List<Movie>? Movies { get; set; }

    }
}
