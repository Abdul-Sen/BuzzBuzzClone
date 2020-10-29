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
        public string State { get; set; }
        public string StreetName { get; set; }
        public int StreetNo {get; set;}

        public override string ToString()
        {
            return $"Id: {Id} , Country: {Country} , State: {State}, Street Name: {StreetName} StreetNo: {StreetNo}";
        }
    }
}