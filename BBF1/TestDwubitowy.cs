using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBF1
{
	class TestDwubitowy
	{
		public int suma = 0; //00
		public int sumb = 0; //01
		public int sumc = 0; //10
		public int sumd = 0; //11

		public void Foo(int[] a)
		{
			for( int i = 0; i < a.Length - 1; i++)
			{
				if (a[i] == 0 && a[i + 1] == 0)
				{
					suma++;
				}
				else if (a[i] == 0 && a[i + 1] == 1)
				{
					sumb++;
				}
				else if (a[i] == 1 && a[i + 1] == 0)
				{
					sumc++;
				}
				else if (a[i] == 1 && a[i + 1] == 1)
				{
					sumd++;
				}
			}
		}
	}
}
