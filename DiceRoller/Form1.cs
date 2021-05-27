using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Die myDie = new Die();
            MessageBox.Show($"You rolled {myDie.Roll()}");
            myDie.Roll();
            MessageBox.Show($"You rolled {myDie.FaceUpValue}");
        }
    }
}
