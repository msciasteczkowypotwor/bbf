using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBF1
{
	class TestPokerowy
	{
		public int suma0000 = 0;
		public int suma0001 = 0;
		public int suma0010 = 0;
		public int suma0011 = 0;

		public int suma0100 = 0;
		public int suma0101 = 0;
		public int suma0110 = 0;
		public int suma0111 = 0;

		public int suma1000 = 0;
		public int suma1001 = 0;
		public int suma1010 = 0;
		public int suma1011 = 0;

		public int suma1100 = 0;
		public int suma1101 = 0;
		public int suma1110 = 0;
		public int suma1111 = 0;

		public void Fuu(ulong[] a)
		{
			int pom = 0;
			while (pom < a.Length)
			{
				if (a[pom] == 0)
				{
					if (a[pom + 1] == 0)
					{
						if (a[pom + 2] == 0)
						{
							if (a[pom + 3] == 0)
							{
								suma0000++;
							}
							else
							{
								suma0001++;
							}
						}
						else
						{
							if (a[pom + 3] == 0)
							{
								suma0010++;
							}
							else
							{
								suma0011++;
							}
						}
					}
					else
					{
						if (a[pom + 2] == 0)
						{
							if (a[pom + 3] == 0)
							{
								suma0100++;
							}
							else
							{
								suma0101++;
							}
						}
						else
						{
							if (a[pom + 3] == 0)
							{
								suma0110++;
							}
							else
							{
								suma0111++;
							}
						}
					}
				}
				else
				{
					if (a[pom + 1] == 0)
					{
						if (a[pom + 2] == 0)
						{
							if (a[pom + 3] == 0)
							{
								suma1000++;
							}
							else
							{
								suma1001++;
							}
						}
						else
						{
							if (a[pom + 3] == 0)
							{
								suma1010++;
							}
							else
							{
								suma1011++;
							}
						}
					}
					else
					{
						if (a[pom + 2] == 0)
						{
							if (a[pom + 3] == 0)
							{
								suma1100++;
							}
							else
							{
								suma1101++;
							}
						}
						else
						{
							if (a[pom + 3] == 0)
							{
								suma1110++;
							}
							else
							{
								suma1111++;
							}
						}
					}
				}
				pom += 4;
			}
		}
		public bool Spr2000()
		{
			float a = 2.16f;
			float b = 46.17f;

			float x = 16/5000f;
			float SUMA = suma0000 * suma0000 + suma0001 * suma0001 + suma0010 * suma0010 + suma0011 * suma0011 +
						suma0100 * suma0100 + suma0101 * suma0101 + suma0110 * suma0110 + suma0111 * suma0111 +
						suma1000 * suma1000 + suma1001 * suma1001 + suma1010 * suma1010 + suma1011 * suma1011 +
						suma1100 * suma1100 + suma1101 * suma1101 + suma1110 * suma1110 + suma1111 * suma1111;
			x = x * (float)SUMA;
			x = x - 5000;

			if (x > a && x < b)
				return true;
			return false;
		}


	}
}
