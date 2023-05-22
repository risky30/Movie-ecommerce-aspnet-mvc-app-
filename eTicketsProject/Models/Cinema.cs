<<<<<<< HEAD
﻿using eTicketsProject.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicketsProject.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cinema Logo is required !")]
        [Display(Name = "Cinema Logo")]
        public string? Logo { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required(ErrorMessage = "Please enter the Cinema's name !")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "the name must be between 5 and 60 chars")]
        [Display(Name = "Name")]
        public string? Name { get; set; }

        [MinLength(30, ErrorMessage = "Description should contains at least 30 chars !")]
        [Required(ErrorMessage = "A Description is required !")]   
=======
﻿using System.ComponentModel.DataAnnotations;

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
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130
        [Display(Name = "Description")]
        public string? Description { get; set; }

        //Relationships ; cinema can have a list of movies
        public List<Movie>? Movies { get; set; }

    }
}
