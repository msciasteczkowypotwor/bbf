namespace BBF1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSeedNumber = new System.Windows.Forms.TextBox();
			this.txtBoxBlumeNumber = new System.Windows.Forms.TextBox();
			this.txtBoxSecoundPrime = new System.Windows.Forms.TextBox();
			this.txtBoxFirstPrime = new System.Windows.Forms.TextBox();
			this.txtBoxToRange = new System.Windows.Forms.TextBox();
			this.txtBoxFromRange = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGenerateRandomString = new System.Windows.Forms.Button();
			this.btnTestCzestosci = new System.Windows.Forms.Button();
			this.btnTestDwubitowy = new System.Windows.Forms.Button();
			this.btnTestSerii = new System.Windows.Forms.Button();
			this.btn10xAllTests = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnGenerate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtSeedNumber);
			this.groupBox1.Controls.Add(this.txtBoxBlumeNumber);
			this.groupBox1.Controls.Add(this.txtBoxSecoundPrime);
			this.groupBox1.Controls.Add(this.txtBoxFirstPrime);
			this.groupBox1.Controls.Add(this.txtBoxToRange);
			this.groupBox1.Controls.Add(this.txtBoxFromRange);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(286, 187);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(10, 145);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 11;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(149, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(15, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "s:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(149, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "m:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(149, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "q:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "p:";
			// 
			// txtSeedNumber
			// 
			this.txtSeedNumber.Location = new System.Drawing.Point(171, 132);
			this.txtSeedNumber.Name = "txtSeedNumber";
			this.txtSeedNumber.Size = new System.Drawing.Size(100, 20);
			this.txtSeedNumber.TabIndex = 6;
			// 
			// txtBoxBlumeNumber
			// 
			this.txtBoxBlumeNumber.Location = new System.Drawing.Point(171, 96);
			this.txtBoxBlumeNumber.Name = "txtBoxBlumeNumber";
			this.txtBoxBlumeNumber.Size = new System.Drawing.Size(100, 20);
			this.txtBoxBlumeNumber.TabIndex = 5;
			// 
			// txtBoxSecoundPrime
			// 
			this.txtBoxSecoundPrime.Location = new System.Drawing.Point(171, 57);
			this.txtBoxSecoundPrime.Name = "txtBoxSecoundPrime";
			this.txtBoxSecoundPrime.Size = new System.Drawing.Size(100, 20);
			this.txtBoxSecoundPrime.TabIndex = 4;
			// 
			// txtBoxFirstPrime
			// 
			this.txtBoxFirstPrime.Location = new System.Drawing.Point(33, 57);
			this.txtBoxFirstPrime.Name = "txtBoxFirstPrime";
			this.txtBoxFirstPrime.Size = new System.Drawing.Size(100, 20);
			this.txtBoxFirstPrime.TabIndex = 3;
			// 
			// txtBoxToRange
			// 
			this.txtBoxToRange.Location = new System.Drawing.Point(171, 20);
			this.txtBoxToRange.Name = "txtBoxToRange";
			this.txtBoxToRange.Size = new System.Drawing.Size(100, 20);
			this.txtBoxToRange.TabIndex = 2;
			this.txtBoxToRange.Text = "8000";
			// 
			// txtBoxFromRange
			// 
			this.txtBoxFromRange.Location = new System.Drawing.Point(53, 20);
			this.txtBoxFromRange.Name = "txtBoxFromRange";
			this.txtBoxFromRange.Size = new System.Drawing.Size(100, 20);
			this.txtBoxFromRange.TabIndex = 1;
			this.txtBoxFromRange.Text = "4000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Range";
			// 
			// btnGenerateRandomString
			// 
			this.btnGenerateRandomString.Location = new System.Drawing.Point(12, 246);
			this.btnGenerateRandomString.Name = "btnGenerateRandomString";
			this.btnGenerateRandomString.Size = new System.Drawing.Size(201, 84);
			this.btnGenerateRandomString.TabIndex = 1;
			this.btnGenerateRandomString.Text = "Generate random string \r\nof 20 000 0\'s and 1\'s";
			this.btnGenerateRandomString.UseVisualStyleBackColor = true;
			this.btnGenerateRandomString.Click += new System.EventHandler(this.btnGenerateRandomString_Click);
			// 
			// btnTestCzestosci
			// 
			this.btnTestCzestosci.Location = new System.Drawing.Point(362, 21);
			this.btnTestCzestosci.Name = "btnTestCzestosci";
			this.btnTestCzestosci.Size = new System.Drawing.Size(194, 23);
			this.btnTestCzestosci.TabIndex = 2;
			this.btnTestCzestosci.Text = "TestCzestosci";
			this.btnTestCzestosci.UseVisualStyleBackColor = true;
			this.btnTestCzestosci.Click += new System.EventHandler(this.btnTestCzestosci_Click);
			// 
			// btnTestDwubitowy
			// 
			this.btnTestDwubitowy.Location = new System.Drawing.Point(362, 51);
			this.btnTestDwubitowy.Name = "btnTestDwubitowy";
			this.btnTestDwubitowy.Size = new System.Drawing.Size(194, 23);
			this.btnTestDwubitowy.TabIndex = 3;
			this.btnTestDwubitowy.Text = "TestDwubitowy";
			this.btnTestDwubitowy.UseVisualStyleBackColor = true;
			this.btnTestDwubitowy.Click += new System.EventHandler(this.btnTestDwubitowy_Click);
			// 
			// btnTestSerii
			// 
			this.btnTestSerii.Location = new System.Drawing.Point(362, 80);
			this.btnTestSerii.Name = "btnTestSerii";
			this.btnTestSerii.Size = new System.Drawing.Size(194, 23);
			this.btnTestSerii.TabIndex = 4;
			this.btnTestSerii.Text = "TestSerii";
			this.btnTestSerii.UseVisualStyleBackColor = true;
			this.btnTestSerii.Click += new System.EventHandler(this.btnTestSerii_Click);
			// 
			// btn10xAllTests
			// 
			this.btn10xAllTests.Location = new System.Drawing.Point(696, 246);
			this.btn10xAllTests.Name = "btn10xAllTests";
			this.btn10xAllTests.Size = new System.Drawing.Size(75, 23);
			this.btn10xAllTests.TabIndex = 5;
			this.btn10xAllTests.Text = "10xAllTests";
			this.btn10xAllTests.UseVisualStyleBackColor = true;
			this.btn10xAllTests.Click += new System.EventHandler(this.btn10xAllTests_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn10xAllTests);
			this.Controls.Add(this.btnTestSerii);
			this.Controls.Add(this.btnTestDwubitowy);
			this.Controls.Add(this.btnTestCzestosci);
			this.Controls.Add(this.btnGenerateRandomString);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSeedNumber;
		private System.Windows.Forms.TextBox txtBoxBlumeNumber;
		private System.Windows.Forms.TextBox txtBoxSecoundPrime;
		private System.Windows.Forms.TextBox txtBoxFirstPrime;
		private System.Windows.Forms.TextBox txtBoxToRange;
		private System.Windows.Forms.TextBox txtBoxFromRange;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnGenerateRandomString;
		private System.Windows.Forms.Button btnTestCzestosci;
		private System.Windows.Forms.Button btnTestDwubitowy;
		private System.Windows.Forms.Button btnTestSerii;
		private System.Windows.Forms.Button btn10xAllTests;
	}
}

