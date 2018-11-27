using System;
using System.IO;
using System.Windows.Forms;

namespace BBF1
{
	public partial class Form1 : Form
	{
		private PrimeGenerator primeGenerator;
		private PseudoRandomString pseudoRandomString;
		private SaveFileDialog sfd;
		private StreamWriter bw;
		private TestCzestosci tCz;
		//private TestDwubitowy tD;
		private TestSerii tS;
		private TestDlugiejSerii tDS;
		private TestPokerowy tP;

		public Form1()
		{
			InitializeComponent();

			sfd = new SaveFileDialog();
			sfd.Filter = "Text File|*.txt";
			sfd.Title = "Create file for output";
			if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				string path = sfd.FileName;
				bw = new StreamWriter(File.Create(path));
				bw.Dispose();
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			primeGenerator =
				new PrimeGenerator(Convert.ToUInt32(txtBoxFromRange.Text),
				Convert.ToUInt32(txtBoxToRange.Text));

			txtBoxFirstPrime.Text = primeGenerator.firstPrime.ToString();
			txtBoxSecoundPrime.Text = primeGenerator.secoundPrime.ToString();
			txtBoxBlumeNumber.Text = primeGenerator.m.ToString();
			txtSeedNumber.Text = primeGenerator.s.ToString();

		}

		private void btnGenerateRandomString_Click(object sender, EventArgs e)
		{
			pseudoRandomString = new PseudoRandomString();
			pseudoRandomString.m = primeGenerator.m;
			pseudoRandomString.s = primeGenerator.s;
			pseudoRandomString.GenerateString();
			string path = sfd.FileName;
			//bw = new StreamWriter(sfd.FileName, append: true);
			//bw.WriteLine("p: " + txtBoxFirstPrime.Text);
			//bw.WriteLine("q: " + txtBoxSecoundPrime.Text);
			//bw.WriteLine("m: " + txtBoxBlumeNumber.Text);
			//bw.WriteLine("s: " + txtSeedNumber.Text);

			//bw.Dispose();
		}

		private void btnTestCzestosci_Click(object sender, EventArgs e)
		{
			//btnGenerate_Click(sender, e);
			//btnGenerateRandomString_Click(sender, e);
			tCz = new TestCzestosci();
			tCz.Fuu(pseudoRandomString.list);
			//bw = new StreamWriter(sfd.FileName, append: true);
			//bw.WriteLine(tCz.sum);
			//bw.Dispose();
		}

		private void btnTestDwubitowy_Click(object sender, EventArgs e)
		{
			//tD = new TestDwubitowy();
			//tD.Foo(pseudoRandomString.list);
			//bw = new StreamWriter(sfd.FileName, append: true);
			//bw.WriteLine(tD.suma + " " + tD.sumb + " " + tD.sumc + " " + tD.sumd);
			//bw.Dispose();
		}

		private void btnTestSerii_Click(object sender, EventArgs e)
		{
			tS = new TestSerii();
			tS.Fuu(pseudoRandomString.list);
			//bw = new StreamWriter(sfd.FileName, append: true);
			//bw.WriteLine(tS.sum1 + " " + tS.sum2 + " " + tS.sum3 + " " + tS.sum4 
			//	+ " " + tS.sum5 + " " + tS.sum6andmore);
			//bw.Dispose();
		}

		private void btn10xAllTests_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 10; i++)
			{
				btnGenerate_Click(sender, e);
				btnGenerateRandomString_Click(sender, e);
				btnTestCzestosci_Click(sender, e);
				btnTestDwubitowy_Click(sender, e);
				btnTestSerii_Click(sender, e);
				btnTestDlugiejSerii_Click(sender, e);
				btnTestPokerowy_Click(sender, e);
			}
		}

		private void btnTestDlugiejSerii_Click(object sender, EventArgs e)
		{
			tDS = new TestDlugiejSerii();
			tDS.Fuu(pseudoRandomString.list);
			//bw = new StreamWriter(sfd.FileName, append: true);
			//bw.WriteLine(tDS.suma);
			//bw.Dispose();
		}

		private void btnTestPokerowy_Click(object sender, EventArgs e)
		{
			tP = new TestPokerowy();
			tP.Fuu(pseudoRandomString.list);
			//bw = new StreamWriter(sfd.FileName, append: true);
			//bw.WriteLine("0000: {0}, 0001: {1}, 0010: {2}, 0011: {3}, " +
			//			"0100: {4}, 0101: {5}, 0110: {6}, 0111: {7}, " +
			//			"1000: {8}, 1001: {9}, 1010: {10}, 1011: {11}, " +
			//			"1100: {12}, 1101: {13}, 1110: {14}, 1111: {15}",
			//			tP.suma0000,tP.suma0001,tP.suma0010,tP.suma0011,
			//			tP.suma0100,tP.suma0101,tP.suma0110,tP.suma0111,
			//			tP.suma1000, tP.suma1001, tP.suma1010, tP.suma1011,
			//			tP.suma1100, tP.suma1101, tP.suma1110, tP.suma1111);
			//bw.Dispose();
		}

		private void btnTestTilFound_Click(object sender, EventArgs e)
		{
			ulong pom = 0;
			while (pom<5000000)
			{
				for (int i = 0; i < 1; i++)
				{
					int counter = 0;
					do
					{
						btnGenerate_Click(sender, e);
						btnGenerateRandomString_Click(sender, e);
						btnTestCzestosci_Click(sender, e);
						//btnTestDwubitowy_Click(sender, e);
						btnTestSerii_Click(sender, e);
						btnTestDlugiejSerii_Click(sender, e);
						btnTestPokerowy_Click(sender, e);
						counter++;

					} while (!(tCz.Spr2000() && tS.Spr2000() && tDS.Spr20000() && tP.Spr2000()));
					bw = new StreamWriter(sfd.FileName, append: true);

					bw.WriteLine(txtBoxFromRange.Text + " - " + txtBoxToRange.Text);

					bw.WriteLine("p: " + txtBoxFirstPrime.Text);
					bw.WriteLine("q: " + txtBoxSecoundPrime.Text);
					bw.WriteLine("m: " + txtBoxBlumeNumber.Text);
					bw.WriteLine("s: " + txtSeedNumber.Text);
					foreach(var a in pseudoRandomString.list)
					bw.Write(a);
					bw.WriteLine("");
					bw.WriteLine(tCz.sum);

					bw.WriteLine(tS.sum1 + " " + tS.sum2 + " " + tS.sum3 + " " + tS.sum4
						+ " " + tS.sum5 + " " + tS.sum6andmore);

					bw.WriteLine(tDS.suma);

					bw.WriteLine("0000: {0}, 0001: {1}, 0010: {2}, 0011: {3}, " +
								"0100: {4}, 0101: {5}, 0110: {6}, 0111: {7}, " +
								"1000: {8}, 1001: {9}, 1010: {10}, 1011: {11}, " +
								"1100: {12}, 1101: {13}, 1110: {14}, 1111: {15}",
								tP.suma0000, tP.suma0001, tP.suma0010, tP.suma0011,
								tP.suma0100, tP.suma0101, tP.suma0110, tP.suma0111,
								tP.suma1000, tP.suma1001, tP.suma1010, tP.suma1011,
								tP.suma1100, tP.suma1101, tP.suma1110, tP.suma1111);

					bw.WriteLine(counter);
					bw.Dispose();
					counter = 0;
				}
				pom = ulong.Parse(txtBoxFromRange.Text);
				pom += 10000;
				txtBoxFromRange.Text = pom.ToString();
				pom = ulong.Parse(txtBoxToRange.Text);
				pom += 10000;
				txtBoxToRange.Text = pom.ToString();
			}
		}
	}
}
