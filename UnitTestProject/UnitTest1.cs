using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CHWebAPI.Controllers;
using CHWebAPI.Models;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var evt1 = new AEvent( );
            evt1.EventName = "Event 1";
            evt1.EventSummary = "This is event 1";
            evt1.EventLocation = "Naperville";
            evt1.EventURL = "http://www.google.com";

            AEventDetailsController controller = new AEventDetailsController();

            // Act
            AEvent response = controller.Get(1);

            // Assert
            Assert.AreEqual(evt1.EventName, response.EventName);

        }

    }
}
