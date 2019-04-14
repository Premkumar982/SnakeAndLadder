using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder.Factory
{
    public class FactoryClass
    {
        public Game CreateGameInstance()
        {
            return new Game();
        }
    }
}
