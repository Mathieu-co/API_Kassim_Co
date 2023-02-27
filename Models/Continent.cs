namespace API_Kassim_Co.Models
using System

{
    public class Continent
    {
        public int Id_c { get; set; } 

        public string Nom { get; set; } 

        ICollection<Pays> paysList;

        public class Pays : Continent
        {
            public int Id_p { get; set; }

            public string Name { get; set; }
            
            ICollection<Population> popList;


        }

    }


}