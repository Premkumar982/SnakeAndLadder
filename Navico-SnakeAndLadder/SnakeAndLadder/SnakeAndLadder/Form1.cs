using BusinessLogic.Interface;
using SnakeAndLadder.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAndLadder
{
    public partial class Form1 : Form
    {
        FactoryClass factoryClass;
        public Form1()
        {
            InitializeComponent();
            factoryClass = new FactoryClass();
        }

        private void StartGame(object sender, EventArgs e)
        {
            int NumberofPlayers = 0;
            bool isValid = int.TryParse(txtNumberOfPlayers.Text, out NumberofPlayers);
            if ((!isValid) || NumberofPlayers <= 1)
            {
                MessageBox.Show("Please enter a valid number of players");
                return;
            }

            try
            {

                IGame game = factoryClass.CreateGameInstance();
                string strWinner = game.Play(NumberofPlayers);
                lblMessage.Text = $"Winner is {strWinner}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
