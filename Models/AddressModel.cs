using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Showcase.Models {
    public class AddressModel
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public int State { get; set; }
        public int StreetName { get; set; }
        public int StreetNo {get; set;}
    }
}