/*
 * Created by SharpDevelop.
 * User: rm20212930048
 * Date: 08/11/2021
 * Time: 14:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace forca
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonA;
		private System.Windows.Forms.Button buttonW;
		private System.Windows.Forms.Button buttonQ;
		private System.Windows.Forms.Button buttonE;
		private System.Windows.Forms.Button buttonR;
		private System.Windows.Forms.Button buttonY;
		private System.Windows.Forms.Button buttonT;
		private System.Windows.Forms.Button buttonO;
		private System.Windows.Forms.Button buttonU;
		private System.Windows.Forms.Button buttonN;
		private System.Windows.Forms.Button buttonP;
		private System.Windows.Forms.Button buttonX;
		private System.Windows.Forms.Button buttonC;
		private System.Windows.Forms.Button buttonV;
		private System.Windows.Forms.Button buttonL;
		private System.Windows.Forms.Button buttonK;
		private System.Windows.Forms.Button buttonJ;
		private System.Windows.Forms.Button buttonH;
		private System.Windows.Forms.Button buttonG;
		private System.Windows.Forms.Button buttonS;
		private System.Windows.Forms.Button buttonZ;
		private System.Windows.Forms.Button buttonM;
		private System.Windows.Forms.Button buttonB;
		private System.Windows.Forms.Button buttonF;
		private System.Windows.Forms.Button buttonD;
		private System.Windows.Forms.Button buttonI;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.TextBox word;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label secret;
		private System.Windows.Forms.Button restart;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.buttonA = new System.Windows.Forms.Button();
			this.buttonW = new System.Windows.Forms.Button();
			this.buttonQ = new System.Windows.Forms.Button();
			this.buttonE = new System.Windows.Forms.Button();
			this.buttonR = new System.Windows.Forms.Button();
			this.buttonY = new System.Windows.Forms.Button();
			this.buttonT = new System.Windows.Forms.Button();
			this.buttonO = new System.Windows.Forms.Button();
			this.buttonU = new System.Windows.Forms.Button();
			this.buttonN = new System.Windows.Forms.Button();
			this.buttonP = new System.Windows.Forms.Button();
			this.buttonX = new System.Windows.Forms.Button();
			this.buttonC = new System.Windows.Forms.Button();
			this.buttonV = new System.Windows.Forms.Button();
			this.buttonL = new System.Windows.Forms.Button();
			this.buttonK = new System.Windows.Forms.Button();
			this.buttonJ = new System.Windows.Forms.Button();
			this.buttonH = new System.Windows.Forms.Button();
			this.buttonG = new System.Windows.Forms.Button();
			this.buttonS = new System.Windows.Forms.Button();
			this.buttonZ = new System.Windows.Forms.Button();
			this.buttonM = new System.Windows.Forms.Button();
			this.buttonB = new System.Windows.Forms.Button();
			this.buttonF = new System.Windows.Forms.Button();
			this.buttonD = new System.Windows.Forms.Button();
			this.buttonI = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.start = new System.Windows.Forms.Button();
			this.word = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.secret = new System.Windows.Forms.Label();
			this.restart = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonA
			// 
			this.buttonA.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonA.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonA.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonA.Location = new System.Drawing.Point(33, 57);
			this.buttonA.Name = "buttonA";
			this.buttonA.Size = new System.Drawing.Size(47, 43);
			this.buttonA.TabIndex = 0;
			this.buttonA.Text = "A";
			this.buttonA.UseVisualStyleBackColor = false;
			this.buttonA.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonW
			// 
			this.buttonW.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonW.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonW.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonW.Location = new System.Drawing.Point(61, 8);
			this.buttonW.Name = "buttonW";
			this.buttonW.Size = new System.Drawing.Size(47, 43);
			this.buttonW.TabIndex = 1;
			this.buttonW.Text = "W";
			this.buttonW.UseVisualStyleBackColor = false;
			this.buttonW.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonQ
			// 
			this.buttonQ.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonQ.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonQ.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonQ.Location = new System.Drawing.Point(8, 8);
			this.buttonQ.Name = "buttonQ";
			this.buttonQ.Size = new System.Drawing.Size(47, 43);
			this.buttonQ.TabIndex = 2;
			this.buttonQ.Text = "Q";
			this.buttonQ.UseVisualStyleBackColor = false;
			this.buttonQ.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonE
			// 
			this.buttonE.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonE.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonE.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonE.Location = new System.Drawing.Point(114, 8);
			this.buttonE.Name = "buttonE";
			this.buttonE.Size = new System.Drawing.Size(47, 43);
			this.buttonE.TabIndex = 3;
			this.buttonE.Text = "E";
			this.buttonE.UseVisualStyleBackColor = false;
			this.buttonE.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonR
			// 
			this.buttonR.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonR.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonR.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonR.Location = new System.Drawing.Point(167, 8);
			this.buttonR.Name = "buttonR";
			this.buttonR.Size = new System.Drawing.Size(47, 43);
			this.buttonR.TabIndex = 4;
			this.buttonR.Text = "R";
			this.buttonR.UseVisualStyleBackColor = false;
			this.buttonR.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonY
			// 
			this.buttonY.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonY.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonY.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonY.Location = new System.Drawing.Point(273, 8);
			this.buttonY.Name = "buttonY";
			this.buttonY.Size = new System.Drawing.Size(47, 43);
			this.buttonY.TabIndex = 5;
			this.buttonY.Text = "Y";
			this.buttonY.UseVisualStyleBackColor = false;
			this.buttonY.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonT
			// 
			this.buttonT.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonT.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonT.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonT.Location = new System.Drawing.Point(220, 8);
			this.buttonT.Name = "buttonT";
			this.buttonT.Size = new System.Drawing.Size(47, 43);
			this.buttonT.TabIndex = 6;
			this.buttonT.Text = "T";
			this.buttonT.UseVisualStyleBackColor = false;
			this.buttonT.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonO
			// 
			this.buttonO.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonO.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonO.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonO.Location = new System.Drawing.Point(432, 8);
			this.buttonO.Name = "buttonO";
			this.buttonO.Size = new System.Drawing.Size(47, 43);
			this.buttonO.TabIndex = 7;
			this.buttonO.Text = "O";
			this.buttonO.UseVisualStyleBackColor = false;
			this.buttonO.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonU
			// 
			this.buttonU.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonU.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonU.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonU.Location = new System.Drawing.Point(326, 8);
			this.buttonU.Name = "buttonU";
			this.buttonU.Size = new System.Drawing.Size(47, 43);
			this.buttonU.TabIndex = 9;
			this.buttonU.Text = "U";
			this.buttonU.UseVisualStyleBackColor = false;
			this.buttonU.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonN
			// 
			this.buttonN.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonN.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonN.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonN.Location = new System.Drawing.Point(326, 106);
			this.buttonN.Name = "buttonN";
			this.buttonN.Size = new System.Drawing.Size(47, 43);
			this.buttonN.TabIndex = 10;
			this.buttonN.Text = "N";
			this.buttonN.UseVisualStyleBackColor = false;
			this.buttonN.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonP
			// 
			this.buttonP.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonP.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonP.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonP.Location = new System.Drawing.Point(485, 8);
			this.buttonP.Name = "buttonP";
			this.buttonP.Size = new System.Drawing.Size(47, 43);
			this.buttonP.TabIndex = 11;
			this.buttonP.Text = "P";
			this.buttonP.UseVisualStyleBackColor = false;
			this.buttonP.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonX
			// 
			this.buttonX.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonX.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonX.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonX.Location = new System.Drawing.Point(114, 106);
			this.buttonX.Name = "buttonX";
			this.buttonX.Size = new System.Drawing.Size(47, 43);
			this.buttonX.TabIndex = 12;
			this.buttonX.Text = "X";
			this.buttonX.UseVisualStyleBackColor = false;
			this.buttonX.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonC
			// 
			this.buttonC.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonC.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonC.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonC.Location = new System.Drawing.Point(167, 106);
			this.buttonC.Name = "buttonC";
			this.buttonC.Size = new System.Drawing.Size(47, 43);
			this.buttonC.TabIndex = 13;
			this.buttonC.Text = "C";
			this.buttonC.UseVisualStyleBackColor = false;
			this.buttonC.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonV
			// 
			this.buttonV.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonV.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonV.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonV.Location = new System.Drawing.Point(220, 106);
			this.buttonV.Name = "buttonV";
			this.buttonV.Size = new System.Drawing.Size(47, 43);
			this.buttonV.TabIndex = 14;
			this.buttonV.Text = "V";
			this.buttonV.UseVisualStyleBackColor = false;
			this.buttonV.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonL
			// 
			this.buttonL.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonL.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonL.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonL.Location = new System.Drawing.Point(457, 57);
			this.buttonL.Name = "buttonL";
			this.buttonL.Size = new System.Drawing.Size(47, 43);
			this.buttonL.TabIndex = 15;
			this.buttonL.Text = "L";
			this.buttonL.UseVisualStyleBackColor = false;
			this.buttonL.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonK
			// 
			this.buttonK.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonK.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonK.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonK.Location = new System.Drawing.Point(404, 57);
			this.buttonK.Name = "buttonK";
			this.buttonK.Size = new System.Drawing.Size(47, 43);
			this.buttonK.TabIndex = 16;
			this.buttonK.Text = "K";
			this.buttonK.UseVisualStyleBackColor = false;
			this.buttonK.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonJ
			// 
			this.buttonJ.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonJ.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonJ.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonJ.Location = new System.Drawing.Point(351, 57);
			this.buttonJ.Name = "buttonJ";
			this.buttonJ.Size = new System.Drawing.Size(47, 43);
			this.buttonJ.TabIndex = 17;
			this.buttonJ.Text = "J";
			this.buttonJ.UseVisualStyleBackColor = false;
			this.buttonJ.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonH
			// 
			this.buttonH.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonH.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonH.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonH.Location = new System.Drawing.Point(298, 57);
			this.buttonH.Name = "buttonH";
			this.buttonH.Size = new System.Drawing.Size(47, 43);
			this.buttonH.TabIndex = 18;
			this.buttonH.Text = "H";
			this.buttonH.UseVisualStyleBackColor = false;
			this.buttonH.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonG
			// 
			this.buttonG.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonG.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonG.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonG.Location = new System.Drawing.Point(245, 57);
			this.buttonG.Name = "buttonG";
			this.buttonG.Size = new System.Drawing.Size(47, 43);
			this.buttonG.TabIndex = 19;
			this.buttonG.Text = "G";
			this.buttonG.UseVisualStyleBackColor = false;
			this.buttonG.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonS
			// 
			this.buttonS.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonS.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonS.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonS.Location = new System.Drawing.Point(86, 57);
			this.buttonS.Name = "buttonS";
			this.buttonS.Size = new System.Drawing.Size(47, 43);
			this.buttonS.TabIndex = 20;
			this.buttonS.Text = "S";
			this.buttonS.UseVisualStyleBackColor = false;
			this.buttonS.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonZ
			// 
			this.buttonZ.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonZ.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonZ.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonZ.Location = new System.Drawing.Point(61, 106);
			this.buttonZ.Name = "buttonZ";
			this.buttonZ.Size = new System.Drawing.Size(47, 43);
			this.buttonZ.TabIndex = 21;
			this.buttonZ.Text = "Z";
			this.buttonZ.UseVisualStyleBackColor = false;
			this.buttonZ.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonM
			// 
			this.buttonM.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonM.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonM.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonM.Location = new System.Drawing.Point(379, 106);
			this.buttonM.Name = "buttonM";
			this.buttonM.Size = new System.Drawing.Size(47, 43);
			this.buttonM.TabIndex = 22;
			this.buttonM.Text = "M";
			this.buttonM.UseVisualStyleBackColor = false;
			this.buttonM.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonB
			// 
			this.buttonB.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonB.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonB.Location = new System.Drawing.Point(273, 106);
			this.buttonB.Name = "buttonB";
			this.buttonB.Size = new System.Drawing.Size(47, 43);
			this.buttonB.TabIndex = 23;
			this.buttonB.Text = "B";
			this.buttonB.UseVisualStyleBackColor = false;
			this.buttonB.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonF
			// 
			this.buttonF.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonF.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonF.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonF.Location = new System.Drawing.Point(192, 57);
			this.buttonF.Name = "buttonF";
			this.buttonF.Size = new System.Drawing.Size(47, 43);
			this.buttonF.TabIndex = 24;
			this.buttonF.Text = "F";
			this.buttonF.UseVisualStyleBackColor = false;
			this.buttonF.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonD
			// 
			this.buttonD.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonD.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonD.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonD.Location = new System.Drawing.Point(139, 57);
			this.buttonD.Name = "buttonD";
			this.buttonD.Size = new System.Drawing.Size(47, 43);
			this.buttonD.TabIndex = 25;
			this.buttonD.Text = "D";
			this.buttonD.UseVisualStyleBackColor = false;
			this.buttonD.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// buttonI
			// 
			this.buttonI.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.buttonI.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonI.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonI.Location = new System.Drawing.Point(379, 8);
			this.buttonI.Name = "buttonI";
			this.buttonI.Size = new System.Drawing.Size(47, 43);
			this.buttonI.TabIndex = 26;
			this.buttonI.Text = "I";
			this.buttonI.UseVisualStyleBackColor = false;
			this.buttonI.Click += new System.EventHandler(this.BotaoTentativa);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonD);
			this.panel1.Controls.Add(this.buttonI);
			this.panel1.Controls.Add(this.buttonF);
			this.panel1.Controls.Add(this.buttonQ);
			this.panel1.Controls.Add(this.buttonB);
			this.panel1.Controls.Add(this.buttonW);
			this.panel1.Controls.Add(this.buttonM);
			this.panel1.Controls.Add(this.buttonE);
			this.panel1.Controls.Add(this.buttonZ);
			this.panel1.Controls.Add(this.buttonR);
			this.panel1.Controls.Add(this.buttonS);
			this.panel1.Controls.Add(this.buttonG);
			this.panel1.Controls.Add(this.buttonT);
			this.panel1.Controls.Add(this.buttonH);
			this.panel1.Controls.Add(this.buttonY);
			this.panel1.Controls.Add(this.buttonV);
			this.panel1.Controls.Add(this.buttonU);
			this.panel1.Controls.Add(this.buttonC);
			this.panel1.Controls.Add(this.buttonJ);
			this.panel1.Controls.Add(this.buttonX);
			this.panel1.Controls.Add(this.buttonO);
			this.panel1.Controls.Add(this.buttonN);
			this.panel1.Controls.Add(this.buttonK);
			this.panel1.Controls.Add(this.buttonA);
			this.panel1.Controls.Add(this.buttonP);
			this.panel1.Controls.Add(this.buttonL);
			this.panel1.Location = new System.Drawing.Point(12, 211);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 161);
			this.panel1.TabIndex = 27;
			this.panel1.Visible = false;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.start);
			this.panel2.Controls.Add(this.word);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(232, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(448, 129);
			this.panel2.TabIndex = 28;
			// 
			// start
			// 
			this.start.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.start.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.start.ForeColor = System.Drawing.SystemColors.Control;
			this.start.Location = new System.Drawing.Point(184, 80);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(112, 43);
			this.start.TabIndex = 27;
			this.start.Text = "Começar";
			this.start.UseVisualStyleBackColor = false;
			this.start.Click += new System.EventHandler(this.StartClick);
			// 
			// word
			// 
			this.word.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.word.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.word.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.word.ForeColor = System.Drawing.Color.White;
			this.word.Location = new System.Drawing.Point(131, 45);
			this.word.Name = "word";
			this.word.Size = new System.Drawing.Size(206, 29);
			this.word.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(69, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Insira uma palavra e inicie o jogo!";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			// 
			// secret
			// 
			this.secret.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secret.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.secret.Location = new System.Drawing.Point(314, 158);
			this.secret.Name = "secret";
			this.secret.Size = new System.Drawing.Size(302, 23);
			this.secret.TabIndex = 30;
			// 
			// restart
			// 
			this.restart.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.restart.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restart.ForeColor = System.Drawing.SystemColors.Control;
			this.restart.Location = new System.Drawing.Point(568, 268);
			this.restart.Name = "restart";
			this.restart.Size = new System.Drawing.Size(112, 43);
			this.restart.TabIndex = 28;
			this.restart.Text = "Reiniciar";
			this.restart.UseVisualStyleBackColor = false;
			this.restart.Click += new System.EventHandler(this.RestartClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(692, 384);
			this.Controls.Add(this.restart);
			this.Controls.Add(this.secret);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "forca";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
