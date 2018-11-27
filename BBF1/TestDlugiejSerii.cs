using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBF1
{
	class TestDlugiejSerii
	{
		public int suma = 0;
		public void Fuu(ulong[] a)
		{
			int pom = 0;
			int pom1 = 0;
			while(pom < a.Length)
			{
				int pomsum = 0;
				pom1 = pom;

				while (  pom1 < a.Length && a[pom] == a[pom1])
				{
					pomsum++;
					pom1++;
				}

				pom = pom + pomsum;

				if (pomsum > suma)
					suma = pomsum;

				pomsum = 0;
			}
		}
		public bool Spr20000()
		{
			if (suma >= 26)
				return false;
			return true;
		}
	}
}
