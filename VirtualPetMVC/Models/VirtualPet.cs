using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VirtualPetMVC.Models
{
    public class VirtualPet
    {
        [Key]
        public int VirtualPetID { get; set; }
        [DisplayName("Name of Pet")]
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Thirst { get; set; }
        [DisplayName("Favorite Food")]
        public string FoodType { get; set; }
        public int Health { get; set; }
        public int Tired { get; set; }

        
    }
}