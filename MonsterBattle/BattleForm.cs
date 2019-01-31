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
        bool playerDead;

        int pokemonLvl = 1;


        public BattleForm()
        {
            InitializeComponent();

            randomGenerator = new Random();
        }

        private void reviveEnemy()
        {
            if (enemyDead)
            {
              if(MessageBox.Show("Do you want to fight further?","Fighting", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
                    enemyDead = false;
                    enemyHealthPictureBox.Width = 90;
                    enemyPictureBox.Image = Properties.Resources.pokemon_charizard_front;
              }
                else
                {
                    MessageBox.Show("Thank you for playing!");
                    this.Close();
                }
                
            }

        }


        private void enemyAttack()
        {
            if (!enemyDead)
            {
                if (!playerDead)
                {
                    friendlyPictureBox.Tag = friendlyPictureBox.Image;
                    friendlyPictureBox.Image = Properties.Resources.flameburst;

                    enemyAttackTimer.Start();

                    screenShakeTimer.Start();
                }
            }
        }
        
        private void turnBasedAttack()
        {
            if (enemysTurn)
            {
                enemyAttack();
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
                friendlyExpBarPictureBox.Width += 118;
                if(friendlyExpBarPictureBox.Width >= 118)
                {
                    MessageBox.Show("Your zapdos has leveled up");
                    label1.Text = (pokemonLvl += 1).ToString();
                    friendlyExpBarPictureBox.Width = 0;
                }
                reviveEnemy();

              }

              
        }

        private void enemyAttackTimer_Tick(object sender, EventArgs e)
        {
            screenShakeTimer.Stop();
            enemyAttackTimer.Stop();

            friendlyPictureBox.Image = (Image)friendlyPictureBox.Tag;

            friendlyHealthPictureBox.Width -= 20;

            if (friendlyHealthPictureBox.Width <= 0)
            {
                MessageBox.Show("Zapdos has fainted!");
                playerDead = true;
                friendlyPictureBox.Image = null;
            }
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {
            

            /*friendlyExpBarPictureBox.Width = 0;
            label1.Text = pokemonLvl.ToString();
            enemyPictureBox.Image = Properties.Resources.pokemon_charizard_front;
            friendlyPictureBox.Image = Properties.Resources.pokemon_zapdos_back;*/
        }

        private void BattleForm_Load_1(object sender, EventArgs e)
        {
            friendlyExpBarPictureBox.Width = 0;
            label1.Text = pokemonLvl.ToString();
            enemyPictureBox.Image = Properties.Resources.pokemon_charizard_front;
            friendlyPictureBox.Image = Properties.Resources.pokemon_zapdos_back;

        }
    }
}
