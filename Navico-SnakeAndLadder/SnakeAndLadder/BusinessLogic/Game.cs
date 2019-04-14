using BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    
    public class Game : IGame
    {
        Dictionary<string, int> lstPlayers = new Dictionary<string, int>();
        Random RandomNumberGenerator = new Random();

        public string Play(int NumberOfPlayers)
        {
            int rolledNumber = 0;
            int newValue = 0;
            string strWinner = string.Empty;
            bool isWinnerFound = false;

            try
            {
                for (int i = 1; i <= NumberOfPlayers; i++)
                {
                    lstPlayers.Add(string.Format("Player {0}", i.ToString()), 0);
                }

                while (!lstPlayers.ContainsValue(Common.maxScore))
                {
                    foreach (KeyValuePair<string, int> player in lstPlayers.ToList())
                    {
                        if (!isWinnerFound)
                        {
                            rolledNumber = RandomNumberGenerator.Next(1, Common.maxDiceValue);
                            if (player.Value == 0 && rolledNumber == 1)
                            {
                                lstPlayers[player.Key.ToString()] = rolledNumber;
                            }
                            else if (player.Value > 0)
                            {
                                newValue = Convert.ToInt32(player.Value) + rolledNumber;
                                if (newValue <= Common.maxScore)
                                {
                                    int movedValue = 0;
                                    bool isKeyFound = Common.dicSnakesandLadders.TryGetValue(newValue, out movedValue);
                                    newValue = isKeyFound ? movedValue : newValue;
                                    lstPlayers[player.Key.ToString()] = newValue;

                                    if (newValue == Common.maxScore)
                                    {
                                        strWinner = player.Key.ToString();
                                        isWinnerFound = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strWinner;
        }
    }
}
