using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class owner
    {

        public int id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public int password { get; set; }


        public int idApartment { get; set; }
        [ForeignKey("idApartment")]
        public virtual Apartment Apartment {  get; set; }

    }
}
