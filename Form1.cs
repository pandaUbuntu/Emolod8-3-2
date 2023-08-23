using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Game;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Player player = null;
        private Engine engine = null;
        private Random random = null;
        private Monster monster = null;
        public Form1()
        {
            InitializeComponent();
            this.random = new Random();
            this.engine = new Engine(this.random);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerType type = 0;
            if (this.radioButton1.Checked == true)
            {
                type = PlayerType.Barbarian;
            } else if (this.radioButton2.Checked == true)
            {
                type = PlayerType.Tank;
            } else {
                type = PlayerType.Robber;
            }

            player = this.engine.createPlayer(this.playerNameBox.Text, type);
            monster = this.engine.generateMonster(player.getLevel());

            this.registrationBox.Visible = false;

            this.playerDataBox.Text = player.getName();
            this.levelLabel.Text = player.getLevel().ToString();
            this.healthBar.Maximum = player.getHpMax();
            this.healthBar.Value = player.getHp();

            this.energyBar.Maximum = player.GetenMax();
            this.energyBar.Value = player.GetEn();

            this.button2.Text = player.getSkill(0).getName();
            this.button3.Text = player.getSkill(1).getName();
            this.button4.Text = player.getSkill(2).getName();
            this.button5.Text = player.getSkill(3).getName();
            this.button6.Text = player.getSkill(4).getName();


            this.monsterBox.Text = this.monster.getName();
            this.monsterLevel.Text = monster.getLevel().ToString();
            this.monsterHealthBar.Maximum = monster.getHpMax();
            this.monsterHealthBar.Value = monster.getHp();

            this.playerDataBox.Visible = true;
            this.monsterBox.Visible = true;
           // MessageBox.Show("Привіт! Кнопка працює!");
        }

        private void monsterStrike()
        {
            
            player.damageHp(Engine.prepareStrike(monster.getDamage(), player.Defense()));
            this.healthBar.Value = this.player.getHp();
            this.monsterHealthBar.Value = this.monster.getHp();
            this.energyBar.Value = player.GetEn();
            DialogResult result = new DialogResult();

            if (monster.getHp() == 0)
            {
                result = MessageBox.Show("Ви перемогли!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (result == DialogResult.OK)
                {
                    this.monster = this.engine.generateMonster(player.getLevel());

                    this.monsterBox.Text = this.monster.getName();
                    this.monsterLevel.Text = monster.getLevel().ToString();
                    this.monsterHealthBar.Maximum = monster.getHpMax();
                    this.monsterHealthBar.Value = monster.getHp();
                }
            }

            if (player.getHp() == 0)
            {
                result = MessageBox.Show("Потрачено!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                { 
                    this.Close();
                }
            }


        }

        private void Energy()
        {
            this.energyBar.Value = this.player.getEp();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UseSkillResultData data = player.useSkill(0);
            monster.damageHp(Engine.prepareStrike(data.getValue(), monster.getArmor()));
            
            monsterStrike();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UseSkillResultData data = player.useSkill(1);
            monster.damageHp(Engine.prepareStrike(data.getValue(), monster.getArmor()));
            monsterStrike();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UseSkillResultData data = player.useSkill(2);
            monsterStrike();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UseSkillResultData data = player.useSkill(3);
            monsterStrike();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UseSkillResultData data = player.useSkill(4);
            monsterStrike();
        }
    }

    public class NewProgressBar : ProgressBar
    {
        public NewProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(Brushes.Red, 2, 2, rec.Width, rec.Height);
        }
    }
}
