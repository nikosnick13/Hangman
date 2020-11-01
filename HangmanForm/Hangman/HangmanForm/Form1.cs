using HangmanForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace HangmanForm
{
    public partial class HangmanForm : Form
    {
        //HangmanForm.Properties.Resources.page_1
        //Array pou apothikeyi ta imange
        public Bitmap[] HangPages = { Properties.Resources.page_1, Properties.Resources.page_2, Properties.Resources.page_3, Properties.Resources.page_4, Properties.Resources.page_5, Properties.Resources.page_6, Properties.Resources.page_7, };
        private int WrongGuesses = 0;
        //
        private string[] Words = {} ;
        

        public HangmanForm()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

/// <summary>
/// 
/// </summary>
        private void LoadWords () 
        {
            string[] readText = File.ReadAllLines("common words");
        }

        //methodos pou allazi tis foto patodas  ta grammata
        // 
        private void guessClick(object sender, EventArgs e)
        {
            WrongGuesses++;
            if (WrongGuesses < 7)
            {
                HangmanImage.Image = HangPages[WrongGuesses];
            }
            else
            {
                LostMess.Text = " YOU LOSE TRY AGAIN !!!" ;
            }
            


        }

        private void cmdB_Click(object sender, EventArgs e)
        {

        }

        private void cmdC_Click(object sender, EventArgs e)
        {

        }

        private void cmdF_Click(object sender, EventArgs e)
        {

        }

        private void buttonOfGuesses_Click(object sender, EventArgs e)
        {
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxGuessALetter_TextChanged(object sender, EventArgs e)
        {
            //textBoxGuessALetter.
        }
    }
}
