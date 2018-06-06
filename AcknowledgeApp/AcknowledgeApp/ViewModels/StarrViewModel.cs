using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace AcknowledgeApp.ViewModels
{
    public class StarrViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "STARR Name")]
        public String Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastEdit { get; set; }
        public String Situation { get; set; }
        public String Task { get; set; }
        public String Action { get; set; }
        public String Result { get; set; }
        public String Reflection { get; set; }
        public Emotions Feeling { get; set; }
        public String Coach { get; set; }
    }
}
