namespace API_Kassim_Co.Models
using System;

{
    public class Continent
    {
        public int Id_c { get; set; } 

        public string Nom { get; set; } 

        public ICollection<Pays> paysList { get; set; }



    }


}