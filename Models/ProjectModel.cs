using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Showcase.Models {
    public class ProjectModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int MinSqft { get; set; }
        public int MaxSqft { get; set; }
        public int AddressId {get; set;}
        
        public int BuilderId {get; set;}
    }
}