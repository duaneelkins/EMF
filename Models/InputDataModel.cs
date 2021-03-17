using System;
using System.ComponentModel.DataAnnotations;

namespace EMF.Models
{
    public class InputDataModel
    {
        [Display(Name = "Start Date")]     
        public DateTime StartDate
        {
            get { return DateTime.Now; }
            set { }
        }

        [Display(Name = "Number of Verses")]
        public int NumVerses { get; set; }
    }
}
