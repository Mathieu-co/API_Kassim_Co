using System;
namespace API_Kassim_Co.Models
{
	public class Population
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Pop { get; set; }
		public Pays Pays { get; set; }


	}

}