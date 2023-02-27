using System;

public class Population
{
	public int Id_pop { get; set; }
	public string Name { get; set; }
	public int Population { get; set; }
	public Pays Pays { get; set; }

	public Population(string n, int pop, Pays py) { 
	Name = n; Population = pop; Pays = py;
	}
}
