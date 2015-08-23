using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSajt.Models
{
    public class Proizvod
    {
        private int Id { get; set; }
        private string Naziv { get; set; }
        private string Opis { get; set; }
        private string Kategorija { get; set; }
        //private Proizvodjac Proizvodjac { get; set; }
        private decimal cena { get; set; }
    }
}
