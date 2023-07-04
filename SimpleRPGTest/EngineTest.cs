using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine.Models;
using System.Numerics;
using Engine.ViewModels;

namespace Engine.Test
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void CanCreatePlayerObject()
        {
            var player = new Player();
        }

        [TestMethod]
        public void CanCreateGameSession()
        {
            var session = new GameSession();
        }
    }
}