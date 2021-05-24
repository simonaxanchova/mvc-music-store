﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class Client
    {
        public Client()
        {
            Movies = new List<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public string Telephone { get; set; }

        public string MovieCard { get; set; }

        [Range(1,99, ErrorMessage ="Age must be between 1 and 99")]
        public int Age { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

    }
}