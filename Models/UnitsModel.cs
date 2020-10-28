using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Showcase.Models
{
    public class UnitsModel
    {
        public int Id { get; set; }
        public string FloorSpaceSqft { get; set; }
        public string UnitDesc { get; set; }

        public string AdditionalInfo { get; set; }
        public int BedCount { get; set; }
        public int BathCount { get; set; }
        public int UnitNo { get; set; }
        public int Price { get; set; }
        public int projectId { get; set; }
    }
}