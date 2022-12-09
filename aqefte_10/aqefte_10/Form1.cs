using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldsHardestGame;

namespace aqefte_10
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga;
        int populatioinSize = 100;
        int nbrOfSteps = 10;
        int nbrOfStepIncrement = 10;
        int generation = 1;
        public Form1()
        {
            InitializeComponent();
            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);
            gc.GameOver += Gc_GameOver;

            for (int i = 0; i < populatioinSize; i++)
            {
                gc.AddPlayer(nbrOfSteps);
            }
            var playerList = from p in gc.GetCurrentPlayers()
                             orderby p.GetFitness() descending
                             select p;
            var topPerformers = playerList.Take(populatioinSize / 2).ToList();
            gc.Start();
        }

        private void Gc_GameOver(object sender)
        {
            generation++;
            label1.Text = string.Format(
                "{0}. generáció",
                generation);
        }
    }
}
