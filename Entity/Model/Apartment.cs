using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{


    public enum eType { קרקע, פנטהוז, בנין }
    public enum eArea { צפון, דרום, מרכז }
    public enum eOption { למכירה, להשכרה }
    public class Apartment
    {
        public int Id { get; set; }
        public eArea area { get; set; }
        public eType Type { get; set; }
        public int roomNum { get; set; }
        public int flor { get; set; }
        public int side { get; set; }
        public bool view { get; set; }
        public eOption option { get; set; }
        public bool porch { get; set; }
        public bool status { get; set; }
        public int Shetach { get; set; }




    }
}
