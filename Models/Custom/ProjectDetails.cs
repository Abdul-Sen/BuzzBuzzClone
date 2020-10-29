using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Showcase.Models.Custom {
    public class ProjectDetails
    {
        public ProjectModel ProjectRecord;
        public List<UnitsModel> UnitsList;
    }
}