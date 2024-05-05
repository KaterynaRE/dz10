using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl2
{
	class PlayerFootball
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int NumberInteam { get; set; }
		public override string ToString()
		{
			return $"Last name: {LastName}, First name: {FirstName}, Number in team: {NumberInteam}";
		}
	}

	class FootballTeam: IEnumerable<PlayerFootball>
	{
		List<PlayerFootball> comandZp = new List<PlayerFootball> {
				new PlayerFootball {
					FirstName ="John",
					LastName ="Miller",
					NumberInteam = 22
				},
				new PlayerFootball {
					FirstName ="Candice",
					LastName ="Leman",
					NumberInteam = 10
				},
				new PlayerFootball {
					FirstName ="Joey",
					LastName ="Finch",
					NumberInteam = 15
				},
				new PlayerFootball {
					FirstName ="Nicole",
					LastName ="Taylor",
					NumberInteam = 14
				}
			};

		public IEnumerator<PlayerFootball> GetEnumerator()
		{
			return comandZp.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
