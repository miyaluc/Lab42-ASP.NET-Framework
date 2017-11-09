using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Film
    {
        public int ID
        {
            get; set;
        }
        [StringLength(60, MinimumLength = 3)]
        public string Title
        {
            get; set;
        }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre
        {
            get; set;
        }
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price
        {
            get; set;
        }
        [Display(Name="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate
        {
            get; set;
        }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating
        {
            get; set;
        }
        public class FilmDbContext : DbContext
        {
            public DbSet<Film> Film
            {
                get; set;
            }
        }
    }
}