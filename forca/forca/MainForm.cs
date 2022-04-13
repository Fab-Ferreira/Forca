using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace forca
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		 string palavra;
         int cont;
         int i;
         int numImg = 0;
		
		void BotaoTentativa(object sender, EventArgs e)
		{
			 char letra = (sender as Button).Text[0]; 
             cont = 0; 
             palavra = word.Text; 
             string aux = "";
             for(i = 0; i<palavra.Length; i++) 
             { 
                 if(letra == palavra[i]) 
                 {
                 	cont++;
                    aux += letra;
                 }
                 else
                 { 
                    aux += secret.Text[i]; 
                 }
             } 
             secret.Text = aux; 
             if(cont==0) //Errou 
             { 
                 (sender as Button).BackColor = Color.Red; 
                 numImg++; 
                 pictureBox1.Load("forca"+numImg+".png"); 
                 if(numImg == 7) //Loser 
                 { 
                     panel1.Visible = false; 
                     MessageBox.Show("Você perdeu! A palavra certa era: "+word.Text); 
                 } 
             } 
             else //Acertou 
             { 
                 (sender as Button).BackColor = Color.Green; 
                 if (secret.Text == palavra) //Winner 
                 {
                 	panel1.Visible = false;                 
                    MessageBox.Show("Parabéns! Você adivinhou a palavra "+word.Text+"!"); 
                 } 

             }
             (sender as Button).Enabled = false; 
        } 
		void StartClick(object sender, EventArgs e)
		{
			string aux = "";
            palavra = word.Text; 
            for (i = 0; i<palavra.Length; i++) 
            { 
                aux += "*"; 
            } 
            secret.Text = aux; 
            panel2.Visible = false; 
            panel1.Visible = true; 
		}
		void RestartClick(object sender, EventArgs e)
		{
			 panel2.Visible = true; 
             panel1.Visible = false; 
             word.Clear(); 
             secret.Text = ""; 
             pictureBox1.Load("forca0.png"); 
             numImg = 0; 
             Button[] b = {buttonA, buttonB, buttonC, buttonD, buttonE, buttonF, buttonG, buttonH, buttonI, buttonJ, buttonK, buttonL, buttonM, buttonN, buttonO, buttonP, buttonQ, buttonR, buttonS, buttonT, buttonU, buttonV, buttonW, buttonX, buttonY, buttonZ}; 
             for(int i = 0; i < 26; i++) 
             { 
                 b[i].BackColor = Color.DimGray; 
                 b[i].Enabled = true; 
             } 
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
	}
}