using System;
namespace API_Kassim_Co.Models
{
	public class Population
	{
		public int Id_pop { get; set; }
		public string Name { get; set; }
		public int Pop { get; set; }
		public Pays Pays { get; set; }

		public Population(string n, int popu, Pays py)
		{
			Name = n; Pop = popu; Pays = py;
		}
	}

}