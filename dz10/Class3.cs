using cl1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cl3
{
	class CafeEmployee
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int INN { get; set; }
		public CafeEmployee(string firstName, string lastName, int inn)
		{
			FirstName = firstName;
			LastName = lastName;
			INN = inn;
		}
	}

	class CafeInfo
	{
		public string NameCafe { get; set; }
		public string Location { get; set; }

		public CafeInfo(string nameCafe, string location)
		{
			NameCafe = nameCafe;
			Location = location;
		}
	}

	class CafeData
	{
		public CafeInfo CafeInfo { get; set; }
		public List<CafeEmployee> Employees { get; set; }

		public CafeData(CafeInfo cafeInfo)
		{
			CafeInfo = cafeInfo;
			Employees = new List<CafeEmployee>();
		}
		public void AddPersonal(CafeEmployee personalP)
		{
			Employees.Add(personalP);
		}		
	}

	class Cafe : IEnumerable<CafeData>
	{
		private List<CafeData> CafeDataList;

		public Cafe()
		{
			CafeDataList = new List<CafeData>();
		}

		public void AddCafeData(CafeData cafeData)
		{
			CafeDataList.Add(cafeData);
		}

		public IEnumerator<CafeData> GetEnumerator()
		{
			return CafeDataList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}


}
