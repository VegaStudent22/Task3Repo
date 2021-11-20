using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PoE_GADE6112.Character;

namespace PoE_GADE6112
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine;
        public Form1()
        {
            InitializeComponent();
            gameEngine = new GameEngine();
            UpdateForm();
        }

        public void UpdateForm()
        {
            richTextBox1.Text = gameEngine.ToString();
            lblHeroStat.Text = gameEngine.Map.Hero.ToString();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            var move = gameEngine.Map.Hero.ReturnMove(Movement.UP);//moves hero up
            if (move != Movement.NOMOVEMENT)
            {
                gameEngine.Map.Hero.Move(move);
                gameEngine.Map.UpdateVision();
                UpdateForm();
            }
        }

        private void Down_Click(object sender, EventArgs e)
        {
            var move = gameEngine.Map.Hero.ReturnMove(Movement.DOWN);//moves hero down
            if (move != Movement.NOMOVEMENT)
            {
                gameEngine.Map.Hero.Move(move);
                gameEngine.Map.UpdateVision();
                UpdateForm();
            }
        }

        private void Left_Click(object sender, EventArgs e)
        {
            var move = gameEngine.Map.Hero.ReturnMove(Movement.LEFT);//moves hero left
            if (move != Movement.NOMOVEMENT)
            {
                gameEngine.Map.Hero.Move(move);
                gameEngine.Map.UpdateVision();

                UpdateForm();
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            var move = gameEngine.Map.Hero.ReturnMove(Movement.RIGHT);//moves hero right
            if(move != Movement.NOMOVEMENT)
            {
                gameEngine.Map.Hero.Move(move);
                gameEngine.Map.UpdateVision();
                UpdateForm();
            }
            
        }       
        

        private void Save_Click(object sender, EventArgs e)
        {
            gameEngine.Save();
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            //visionArr index 0 up, 1 right, 2 down, 3 left
            //gameEngine.Map.Hero.VisionArr[3];
            var x = gameEngine.Map.Hero.X;
            var y = gameEngine.Map.Hero.Y;
            var enemy = gameEngine.Map.EnemyArr[0];//to fix
            if (gameEngine.Map.Hero.CheckRange(enemy))
            {
                gameEngine.Map.Hero.Attack(enemy);
            }            
        }        
    }
}



