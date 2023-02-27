using System;

namespace API_Kassim_Co.Models
{
  
    public class Pays
    {
        public int Id_p { get; set; }

        public string Name { get; set; }

        public Continent continent { get; set; }

        public Population population { get; set; }


    }
}