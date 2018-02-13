﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mission.Pluto.UnitTests
{
    [TestClass]
    public class Rover_Multiple_Commands_Tests
    {
        [TestMethod]
        [DataRow("FFRFF", 'N', 2, 2, 'E')]
        [DataRow("RFFFLLFFF", 'N', 0, 0, 'W')]
        [DataRow("BLFFFLFFFRBLFRF", 'E', -5, 3, 'N')]
        public void Multiple_Simple_Commands_Without_Wrapping(string command, char startingFace, int expectedX, int expectedY, char expectedFace)
        {
            var rover = new Rover(0, 0, startingFace);

            rover.HandleCommand(command);

            Assert.AreEqual(expectedX, rover.X);
            Assert.AreEqual(expectedY, rover.Y);
            Assert.AreEqual(expectedFace, rover.Face);
        }
    }
}
