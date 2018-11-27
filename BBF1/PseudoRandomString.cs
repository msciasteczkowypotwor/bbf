using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBF1
{
	class PseudoRandomString
	{
		public ulong[] list = new ulong[20000];
		public ulong s;
		public ulong m;
		public ulong pom;
		public void GenerateString()
		{
			pom = (s * s) % m;
			for (int i = 0; i<list.Length;i++)
			{
				if (pom % 2 == 0)
				{
					list[i] = 0;
				}
				else
				{
					list[i] = 1;
				}
				pom = (pom * pom) % m;
			}
		}

	}
}
