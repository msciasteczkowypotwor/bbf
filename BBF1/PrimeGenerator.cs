using System;
using System.Collections;

namespace BBF1
{
	class PrimeGenerator
	{
		public ulong rangeFrom;
		public ulong rangeTo;
		public ulong firstPrime;
		public ulong secoundPrime;
		public ulong s;
		public ulong m;
		ArrayList list = new ArrayList();
		public PrimeGenerator(ulong rangeFrom, ulong rangeTo)
		{
			this.rangeFrom = rangeFrom;
			this.rangeTo = rangeTo;
			SetList();
			SelectTwoRandomPrime();
			SetMandS();
		}

		private void SetList()
		{
			for(ulong i = this.rangeFrom; i <= this.rangeTo; i++)
			{
				if (IsPrime(i) && IsKongruent(i))
				{
					list.Add(i);
				}
			}
		}
		private bool IsPrime(ulong number)
		{
			if (number == 2)
				return true;
			if (number == 3)
				return true;
			if (number % 2 == 0)
				return false;
			if (number % 3 == 0)
				return false;
			ulong i = 5;
			ulong w = 2;

			while (i * i <= number)
			{
				if (number % i == 0)
					return false;
				i += w;
				w = 6 - w;
			}
			return true;
		}
		private bool IsKongruent(ulong number)
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
				this.firstPrime = (ulong)this.list[rnd.Next(0, this.list.Count)];
				this.secoundPrime = (ulong)this.list[rnd.Next(0, this.list.Count)];
			}
			while (this.firstPrime == this.secoundPrime);

		}
		private void SetMandS()
		{
			this.m = this.firstPrime * secoundPrime;

			this.s = Get64BitRandom(1, m-1);
		}
		private ulong Get64BitRandom(ulong minValue, ulong maxValue)
		{
			// Get a random array of 8 bytes. 
			// As an option, you could also use the cryptography namespace stuff to generate a random byte[8]
			byte[] buffer = new byte[sizeof(ulong)];
			rnd.NextBytes(buffer);
			return BitConverter.ToUInt64(buffer, 0) % (maxValue - minValue + 1) + minValue;
		}
		private readonly Random rnd = new Random();
	}
}
