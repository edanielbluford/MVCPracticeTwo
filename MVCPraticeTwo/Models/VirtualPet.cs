using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPraticeTwo.Models
{
    public class VirtualPet
    {
        [Key]
        public int VirtualPetID { get; set; }
        [DisplayName("Name of Pet")]
        public string Name { get; set; }
        public int Age { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
    }
}