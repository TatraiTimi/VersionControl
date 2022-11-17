using aqefte_week06.Abstractions;
using aqefte_week06.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace aqefte_week06
{
    public partial class Form1 : Form
    {
        List<Abstractions.Toy> _toys=new List<Abstractions.Toy>();
        private Abstractions.Toy _nexttoy;
        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value; DisplayNext(); }
        }


        public Form1()
        {
            InitializeComponent();
            createTimer.Start();
            conveyorTimer.Start();
        }
        private void button_Car_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void buttonBall_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }
        private void DisplayNext()
        {
            if (_nexttoy != null) Controls.Remove(_nexttoy);
            _nexttoy = Factory.CreateNew();
            _nexttoy.Top = lable_Next.Top + lable_Next.Height + 20;
            _nexttoy.Left = lable_Next.Left;
            Controls.Add(_nexttoy);
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = _nexttoy;
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition) maxPosition = toy.Left;
                
            }
            if (maxPosition>1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK) return;
            button.BackColor = colorPicker.Color;
        }
    }
}
