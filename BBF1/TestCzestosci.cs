﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBF1
{
	class TestCzestosci
	{
		public ulong sum = 0;
		public void Fuu(ulong[] a)
		{
			foreach (var c in a)
			{
				if (c == 1)
				{
					sum++;
				}
			}
		}
		public bool Spr2000()
		{
			if (sum > 9725 && sum < 10275)
				return true;
			return false;
		}
	}
}
