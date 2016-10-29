using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace hairByMouth2.Models
{
    public class HairFormModel
    {
        public SearchModel searchModel { get; set; }
        public EntryModel entryModel { get; set; }

    }

    public class SearchModel
    {
        [Required]
        [Display(Name = "Friends Name")]
        public string friendsName { get; set; }
    }


    public class EntryModel
    {
        [Required]
        [Display(Name = "Your Name")]
        public string yourName { get; set; }
        [Required]
        [Display(Name = "Salon Name")]
        public string salonName { get; set; }
        [Required]
        [Display(Name = "Stylist Name")]
        public string stylistName { get; set; }
    }
}