using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeAndLadder.Factory;
using BusinessLogic.Interface;

namespace UnitTests
{
    [TestClass]
    public class SnakeAndLadderTests
    {
        FactoryClass factory = new FactoryClass();
        [TestMethod]
        public void TestMethod1()
        {
            IGame game = factory.CreateGameInstance();
            string str = game.Play(4);
            Assert.IsTrue(!string.IsNullOrEmpty(str));
        }
    }
}
