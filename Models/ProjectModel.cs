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

        // relationship
        public BuilderModel Builder { get; set; }
        public AddressModel Address {get; set; }


        public override string ToString()
        {
            return $"id: {Id} , Name: {Name}, MinSqft: {MinSqft} , MaxSqft: {MaxSqft} AddressFK: {AddressId} , BuilderId: {BuilderId} \n ||  Builder Name: {Builder.BuilderName} , Builder Email: {Builder.Email} , Builder ID: {Builder.Id} || \n Address {Address}";
        }
    }
}