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

namespace EvolAlgorithm
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga = null;

        int populationSize = 100;
        int nbrOfDtepd = 10;
        int nbrOfStepsncrement = 10;
        int generation = 1;
        public Form1()
        {
            InitializeComponent();

            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);

            gc.AddPlayer();
            gc.Start(true);
        }
    }
}
