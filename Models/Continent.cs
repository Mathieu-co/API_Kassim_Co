using System;
namespace API_Kassim_Co.Models
{
    public class Continent
    {
        public int Id { get; set; } 

        public string Nom { get; set; } 

        public ICollection<Pays> paysList { get; set; }



    }


}