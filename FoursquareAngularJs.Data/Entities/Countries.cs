using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FoursquareAngularJs.Data.Entities
{

    public class Countries
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public int Skore { get; set; }
        public DateTime? Ts { get; set; }

    }
}
