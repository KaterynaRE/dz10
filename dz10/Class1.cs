using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace cl1
{
	public class Oceanarium : IEnumerable<Oceanarium>
	{
		private List<Oceanarium> residents;
		public string Name { get; set; }
		public string Species { get; set; }
		public string Habitat { get; set; }

		public Oceanarium(string name, string species, string habitat)
		{
			Name = name;
			Species = species;
			Habitat = habitat;
			residents = new List<Oceanarium>();
		}

		public void AddResident(Oceanarium residentsP)
		{
			residents.Add(residentsP);
		}
				
		public IEnumerator<Oceanarium> GetEnumerator()
		{
			return residents.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	public class Sirenes : Oceanarium
	{
		public string Color { get; set; }

		public Sirenes(string name, string species, string habitat, string ColorSirenesP): base(name, species, habitat)
		{
			Color = ColorSirenesP;
		}
		public string GetColor()
		{
			return Color;
		}

	}
	public class BlueWhale : Oceanarium
	{
		public string Color { get; set; }

		public BlueWhale(string name, string species, string habitat, string ColorBlueWhaleP) : base(name, species, habitat)
		{
			Color = ColorBlueWhaleP;
		}
		public string GetColor()
		{
			return Color;
		}

	}



}