using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeParking.Model
{
    public class Car
    {
        [PrimaryKey , AutoIncrement]
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Engine { get; set; }  
        public int Distance { get; set; }

    }
}
