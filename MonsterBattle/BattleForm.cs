using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterBattle
{
    public partial class BattleForm : Form
    {
        Random randomGenerator;
        bool enemyDead;
        bool enemysTurn = false;

        public BattleForm()
        {
            InitializeComponent();

            randomGenerator = new Random();
        }

        private void turnBasedAttack()
        {
            if (enemysTurn)
            {
                MessageBox.Show("attack");
                enemysTurn = false;
            }
            else
            {
                attackButton.Enabled = false;
                attackButton1.Enabled = false;
                
            }
        }

        private void attackTimer_Tick(object sender, EventArgs e)
        {
            screenShakeTimer.Stop();
            attackTimer.Stop();
            attackButton.Enabled = true;

            enemyPictureBox.Image = (Image)enemyPictureBox.Tag;

            enemyHealthPictureBox.Width -= 20;

            if (enemyHealthPictureBox.Width <= 0)
            {
                MessageBox.Show("Charizard has fainted!");
                enemyDead = true;
                enemyPictureBox.Image = null;
            }
        }

        private void screenShakeTimer_Tick(object sender, EventArgs e)
        {
            this.Top += randomGenerator.Next(-5, 6);
            this.Left += randomGenerator.Next(-5, 6);
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (!enemysTurn)
            {
                if (!enemyDead)
                {
                    enemyPictureBox.Tag = enemyPictureBox.Image;
                    enemyPictureBox.Image = Properties.Resources.attack_lightning;

                    attackButton.Enabled = false;
                    attackTimer.Start();

                    screenShakeTimer.Start();
                }
                else
                {
                    MessageBox.Show("You can not strike Charizard whilst he is already down.");
                }
                enemysTurn = true;
                turnBasedAttack();
            }
            else
            {
                attackButton.Enabled = true;
                attackButton1.Enabled = true;
            }
        }

        private void attackButton1_Click(object sender, EventArgs e)
        {
            if (!enemysTurn)
            {
                if (!enemyDead)
                {
                    enemyPictureBox.Tag = enemyPictureBox.Image;
                    enemyPictureBox.Image = Properties.Resources.attack_lightning;

                    attackButton1.Enabled = false;
                    attackTimer1.Start();

                    screenShakeTimer.Start();
                }
                else
                {
                    MessageBox.Show("You already won CALM DOWN!!");
                }
                enemysTurn = true;
                turnBasedAttack();
            }
            else
            {
                attackButton.Enabled = true;
                attackButton1.Enabled = true;
            }
        }

        private void attackTimer1_Tick(object sender, EventArgs e)
        {
              screenShakeTimer.Stop();
              attackTimer1.Stop();
              attackButton1.Enabled = true;

              enemyPictureBox.Image = (Image)enemyPictureBox.Tag;

              enemyHealthPictureBox.Width -= 35;

              if (enemyHealthPictureBox.Width <= 0)
              {
                MessageBox.Show("Charizard has fainted!");
                enemyDead = true;
                enemyPictureBox.Image = null;
              }
        }
    }
}
