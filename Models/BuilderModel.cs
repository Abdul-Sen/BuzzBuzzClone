using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Showcase.Models {
    public class BuilderModel
    {
        public int Id { get; set; }
        public string BuilderName { get; set; }
        public string Email { get; set; }
        
        public override string ToString()
        {
            return $"Id: {Id} , Builder Name: {BuilderName} , Email: {Email}";
        }
    }
}