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
		public bool Spr2000()
		{
			int sum1_a = 2315;
			int sum1_b = 2684;

			int sum2_a = 1114;
			int sum2_b = 1383;

			int sum3_a = 527;
			int sum3_b = 723;

			int sum4_a = 240;
			int sum4_b = 384;

			int sum5_a = 103;
			int sum5_b = 209;

			int sum6andmore_a = 103;
			int sum6andmore_b = 209;

			if (sum1 >= sum1_a && sum1 <= sum1_b &&
				sum2 >= sum2_a && sum2 <= sum2_b &&
				sum3 >= sum3_a && sum3 <= sum3_b &&
				sum4 >= sum4_a && sum4 <= sum4_b &&
				sum5 >= sum5_a && sum5 <= sum5_b &&
				sum6andmore >= sum6andmore_a && sum6andmore <= sum6andmore_b)
				return true;
			return false;
		}
	}
}
