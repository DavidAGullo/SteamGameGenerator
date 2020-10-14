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

            //Reads Files Line by Line
            StreamReader file = new StreamReader("GamesOnSteam.txt");
            while((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                lBoxGames.Items.Add(line);
                for(int x = 0; x < gameArray.Length; x++)
                {
                    gameArray[x] = line;
                }
                count++;
            }
            file.Close();
            //Test
            Console.WriteLine("There was {0} lines.", count);
            Console.WriteLine(gameArray[5]);
            
            
        }
    }
}
