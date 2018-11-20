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
		private TestDwubitowy tD;
		private TestSerii tS;

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
			bw = new StreamWriter(sfd.FileName, append: true);
			bw.WriteLine("p: " + txtBoxFirstPrime.Text);
			bw.WriteLine("q: " + txtBoxSecoundPrime.Text);
			bw.WriteLine("m: " + txtBoxBlumeNumber.Text);
			bw.WriteLine("s: " + txtSeedNumber.Text);

			bw.Dispose();
		}

		private void btnTestCzestosci_Click(object sender, EventArgs e)
		{
			//btnGenerate_Click(sender, e);
			//btnGenerateRandomString_Click(sender, e);
			tCz = new TestCzestosci();
			tCz.Fuu(pseudoRandomString.list);
			bw = new StreamWriter(sfd.FileName, append: true);
			bw.WriteLine(tCz.sum);
			bw.Dispose();
		}

		private void btnTestDwubitowy_Click(object sender, EventArgs e)
		{
			tD = new TestDwubitowy();
			tD.Foo(pseudoRandomString.list);
			bw = new StreamWriter(sfd.FileName, append: true);
			bw.WriteLine(tD.suma + " " + tD.sumb + " " + tD.sumc + " " + tD.sumd);
			bw.Dispose();
		}

		private void btnTestSerii_Click(object sender, EventArgs e)
		{
			tS = new TestSerii();
			tS.Fuu(pseudoRandomString.list);
			bw = new StreamWriter(sfd.FileName, append: true);
			bw.WriteLine(tS.sum1 + " " + tS.sum2 + " " + tS.sum3 + " " + tS.sum4 
				+ " " + tS.sum5 + " " + tS.sum6andmore);
			bw.Dispose();
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
			}
		}
	}
}
