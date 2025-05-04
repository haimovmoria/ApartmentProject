using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class toRand
    {
        public int id { get; set; }
        public int idApartment { get; set; }
        [ForeignKey("idApartment")]
        public virtual Apartment Apartment { get; set; }

        public int idCustumer { get; set; }
        [ForeignKey("idCustumer")]
        public virtual Custumer Custumer { get; set; }


        public DateTime startDate { get; set; }
        public DateTime lastDate { get; set; }

    }
}
