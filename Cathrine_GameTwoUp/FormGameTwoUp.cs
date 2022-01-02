using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Cathrine_GameTwoUp
{
    public partial class FormGameTwoUp : Form
    {
        Random generator = new Random();
        Random generator2 = new Random();

        double money, betMoney;

        string resourcespath = Application.StartupPath + "\\Resources\\";

        WindowsMediaPlayer loopSound = new WindowsMediaPlayer();
        WindowsMediaPlayer normalSound = new WindowsMediaPlayer();

        public FormGameTwoUp()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            normalSound.URL = resourcespath + "Click.wav";

            DialogResult userAnswer = MessageBox.Show("Are You Sure?",
                "Exit Game", MessageBoxButtons.YesNo);

            if (userAnswer == DialogResult.Yes)
            {
                normalSound.URL = resourcespath + "Click.wav";
                this.Close();
            }
            
        }

        private void FormGameTwoUp_Load(object sender, EventArgs e)
        {
            loopSound.URL = resourcespath + "\\BackgroundMusic.wav";
            loopSound.settings.setMode("loop", true);

            money = 0;
            
            labelDisplayMoney.Text = money.ToString("N0");
            
            textBoxBet.Enabled = false;
            labelDisplayComment.Text = "";
            buttonContinue.Enabled = false;
            buttonPlace.Enabled = false;
            groupBoxBet.Enabled = false;
            buttonToss.Enabled = false;
            buttonCancel.Enabled = false;
        }

        private void buttonPlace_Click(object sender, EventArgs e)
        {
            normalSound.URL = resourcespath + "Click.wav";
            betMoney = int.Parse(textBoxBet.Text);

            if (betMoney > 0)
            {
                if (betMoney <= money)
                {
                    money = money - betMoney;
                    labelDisplayMoney.Text = money.ToString("n0");
                    buttonPlace.Enabled = false;
                    groupBoxBet.Enabled = false;
                    buttonCancel.Enabled = true;
                    buttonToss.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You don't have enough money.");
                }
            }
            else
            {
                MessageBox.Show("You aren't allowed to input negative number.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            normalSound.URL = resourcespath + "Click.wav";
            buttonPlace.Enabled = true;
            groupBoxBet.Enabled = true;
            buttonCancel.Enabled = false;
            buttonToss.Enabled = false;
            money = money + betMoney;
            labelDisplayMoney.Text = money.ToString("n0");

            MessageBox.Show("You have cancelled your bet");
        }

        private void buttonToss_Click(object sender, EventArgs e)
        {
            normalSound.URL = resourcespath + "Click.wav";
            int randomNumber = generator.Next(1, 3);
            if (randomNumber == 1)
            {
                pictureBoxCoin1.Image = Properties.Resources.CoinHead;
            }
            else if (randomNumber == 2)
            {
                pictureBoxCoin1.Image = Properties.Resources.CoinTail;
            }


            int randomNumber2 = generator2.Next(3, 5);
            if (randomNumber == 3)
            {
                pictureBoxCoin2.Image = Properties.Resources.CoinHead;
            }
            else if (randomNumber == 4)
            {
                pictureBoxCoin2.Image = Properties.Resources.CoinTail;
            }
            

            if (randomNumber == 1 && randomNumber2 == 3)
            {
                normalSound.URL = resourcespath + "Correct.wav";
                money = money + (betMoney * 2.0);
                labelDisplayComment.Text = "You win";
            }
            else if (randomNumber == 1 && randomNumber2 == 3)
            {
                normalSound.URL = resourcespath + "Incorrect.wav";
                money = money;
                labelDisplayComment.Text = "You lose";
            }
            else if (randomNumber == 2 && randomNumber2 == 4)
            {
                normalSound.URL = resourcespath + "Correct.wav";
                money = money + (betMoney * 2.0);
                labelDisplayComment.Text = "You win";
            }
            else if (randomNumber == 2 && randomNumber2 == 3)
            {
                normalSound.URL = resourcespath + "Incorrect.wav";
                money = money;
                labelDisplayComment.Text = "You lose";
            }

            buttonContinue.Enabled = true;
            buttonPlace.Enabled = false;
            buttonToss.Enabled = false;
            groupBoxBet.Enabled = false;

            labelDisplayMoney.Text = money.ToString("n0");
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            normalSound.URL = resourcespath + "Click.wav";

            pictureBoxCoin1.Image = Properties.Resources.QuestionMark;
            pictureBoxCoin2.Image = Properties.Resources.QuestionMark;

            textBoxBet.Enabled = true;
            buttonContinue.Enabled = false;
            buttonPlace.Enabled = true;
            buttonToss.Enabled = false;
            buttonCancel.Enabled = false;
            groupBoxBet.Enabled = true;
        }

        private void buttonStartRestart_Click(object sender, EventArgs e)
        {
            normalSound.URL = resourcespath + "Click.wav";
            loopSound.URL = resourcespath + "\\BackgroundMusic.wav";
            loopSound.settings.setMode("loop", true);

            money = 1000000;

            labelDisplayMoney.Text = money.ToString("N0");

            pictureBoxCoin1.Image = Properties.Resources.QuestionMark;
            pictureBoxCoin2.Image = Properties.Resources.QuestionMark;

            buttonPlace.Enabled = true;
            groupBoxBet.Enabled = true;

            textBoxBet.Enabled = true;
            labelDisplayComment.Text = "";
            buttonContinue.Enabled = false;
            buttonToss.Enabled = false;
            buttonCancel.Enabled = false;
        }
    }
}
