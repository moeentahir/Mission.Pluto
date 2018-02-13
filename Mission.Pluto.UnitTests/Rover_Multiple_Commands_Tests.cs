using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mission.Pluto.UnitTests
{
    [TestClass]
    public class Rover_Multiple_Commands_Tests
    {
        [TestMethod]
        public void Handle_Forward_Forward_Right_Forward_Forward_Command()
        {
            var command = "FFRFF";
            var rover = new Rover(0, 0, 'N');

            rover.HandleCommand(command);

            Assert.AreEqual(2, rover.X);
            Assert.AreEqual(2, rover.Y);
            Assert.AreEqual('E', rover.Face);
        }
    }
}
