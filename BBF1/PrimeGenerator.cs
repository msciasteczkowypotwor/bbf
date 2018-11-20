using System;
using System.Collections;

namespace BBF1
{
	class PrimeGenerator
	{
		public uint rangeFrom;
		public uint rangeTo;
		public uint firstPrime;
		public uint secoundPrime;
		public uint s;
		public uint m;
		ArrayList list = new ArrayList();
		public PrimeGenerator(uint rangeFrom, uint rangeTo)
		{
			this.rangeFrom = rangeFrom;
			this.rangeTo = rangeTo;
			SetList();
			SelectTwoRandomPrime();
			SetMandS();
		}

		private void SetList()
		{
			for(uint i = this.rangeFrom; i <= this.rangeTo; i++)
			{
				if (IsPrime(i) && IsKongruent(i))
				{
					list.Add(i);
				}
			}
		}
		private bool IsPrime(uint number)
		{
			if (number == 2)
				return true;
			if (number == 3)
				return true;
			if (number % 2 == 0)
				return false;
			if (number % 3 == 0)
				return false;
			int i = 5;
			int w = 2;

			while (i * i <= number)
			{
				if (number % i == 0)
					return false;
				i += w;
				w = 6 - w;
			}
			return true;
		}
		private bool IsKongruent(uint number)
		{
			if ((number - 3)%4 == 0)
				return true;
			return false;
		}
		private void SelectTwoRandomPrime()
		{
			Random rnd = new Random();
			do
			{
				this.firstPrime = (uint)this.list[rnd.Next(0, this.list.Count)];
				this.secoundPrime = (uint)this.list[rnd.Next(0, this.list.Count)];
			}
			while (this.firstPrime == this.secoundPrime);

		}
		private void SetMandS()
		{
			this.m = this.firstPrime * secoundPrime;
			Random rnd = new Random();
			this.s = (uint)(2 * rnd.Next((int)(m / 3), (int)(m / 2 - 1)));
		}
	}
}
