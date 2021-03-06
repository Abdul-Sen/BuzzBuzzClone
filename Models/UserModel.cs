using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Showcase.Models {
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "User: " + this.Name + ", Email: " + this.Email;
        }

    }
}