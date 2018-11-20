using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBF1
{
	class TestSerii
	{
		public int sum1 = 0;
		public int sum2 = 0;
		public int sum3 = 0;
		public int sum4 = 0;
		public int sum5 = 0;
		public int sum6andmore = 0;

		public void Fuu(int[] a)
		{
			int pom = 0;
			int pom1 = 0;

			while (pom < a.Length)
			{
				pom1 = pom;
				int pomsum=0;

				while (pom1 < a.Length && a[pom] == a[pom1])
				{
					pomsum++;
					pom1++;
				}
				pom = pom + pomsum;


				if (pomsum == 1)
				{
					sum1++;
				}
				else if(pomsum == 2)
				{
					sum2++;
				}
				else if (pomsum == 3)
				{
					sum3++;
				}
				else if (pomsum == 4)
				{
					sum4++;
				}
				else if (pomsum == 5)
				{
					sum5++;
				}
				else if (pomsum == 6 || pomsum>6)
				{
					sum6andmore++;
				}
				pomsum = 0;
			}
		}
	}
}
