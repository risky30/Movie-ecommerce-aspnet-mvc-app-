<<<<<<< HEAD
﻿using eTicketsProject.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicketsProject.Models
{
    public class Actor : IEntityBase
=======
﻿using System.ComponentModel.DataAnnotations;

namespace eTicketsProject.Models
{
    public class Actor
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required !")]
        public string? ProfilePictureURL { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
<<<<<<< HEAD
        [Required(ErrorMessage = "Please enter Full Name !")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Full name must be between 5 and 60 chars")]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [MinLength(30, ErrorMessage = "Biography should contains at least 30 chars !")]
=======
        [Required(ErrorMessage ="Please enter Full Name !")]
        [StringLength(60, MinimumLength =5, ErrorMessage ="Full name must be between 5 and 60 chars")]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [MinLength(30 , ErrorMessage ="Biography should contains at least 30 chars !")]
>>>>>>> 2dc6d8cf8efa28acac0a3b7359a0c3f2cd596130
        [Required(ErrorMessage = "A Biography is required !")]
        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        //Relationship ;
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
