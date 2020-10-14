using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] gameArray = new string[999];
        HoldingList obj = new HoldingList();
        

        //Sets Numbers to Main
        public int Numbers { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string line;

            //Opens File Dialog to Select a txt File
            try
            {
                opnFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                opnFile.ShowDialog();
                //Reads Files Line by Line
                StreamReader file = new StreamReader(opnFile.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    lBoxGames.Items.Add(line);
                    gameArray[count] = line;

                    count++;
                }
                file.Close();
                obj.numMax = count;
                Console.WriteLine(count);
            }
            catch(Exception NoFileSelected)
            {
                Debug.WriteLine("No File was Selected");
            }            
        }
        //Randomifies a Number
        private int RandomNum()
        {
            int num = 0;
            Random rand = new Random();
            num = rand.Next(0, obj.numMax);
            return num;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            int random = RandomNum();
            try
            {
                lBoxGames.SelectedIndex = (random);
                tBoxGameTitle.Text = lBoxGames.Items[random].ToString();
            }
            catch(Exception GameListNotFound)
            {
                Debug.WriteLine(GameListNotFound.Message);
            }
            
            //tBoxGameTitle.Text = (random +1).ToString();

        }
    }
}
