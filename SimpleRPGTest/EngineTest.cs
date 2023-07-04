using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineModelsNS;
using System.Numerics;
using EngineViewModelsNS;

namespace EngineTest
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void CreatePlayerObject()
        {
            var player = new Player();
        }

        [TestMethod]
        public void CreateGameSession()
        {
            var session = new GameSession();
        }
    }
}