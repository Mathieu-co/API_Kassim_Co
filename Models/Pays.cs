using System;

namespace API_Kassim_Co.Models
{
  
    public class Pays
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Continent continent { get; set; }


    }
}