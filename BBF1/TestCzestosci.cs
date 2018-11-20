using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBF1
{
	class TestCzestosci
	{
		public int sum = 0;
		public void Fuu(int[] a)
		{
			foreach (var c in a)
			{
				if (c == 1)
				{
					sum++;
				}
				else
				{
					sum--;
				}
			}
		}
	}
}
