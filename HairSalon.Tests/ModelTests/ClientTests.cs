using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTests
    {

        public ClientTests()
        {
            DB.DatabaseTest();
            Client.ClearAll();
        }

        [TestMethod]
        public void GetAllAndSave_NewClientInDatabase_1()
        {
            Client testClient = new Client("Leela", "2126466800", "New New York");
            testClient.Save(0);

            List<Client> allClients = Client.GetAll();
            Assert.AreEqual(1, allClients.Count);
        }

        [TestMethod]
        public void ClearAll_StylistAfterClear_0()
        {
            Stylist testStylist = new Stylist("Hubert");
            testStylist.Save();
            Stylist.ClearAll();
            List<Stylist> allStylists = Stylist.GetAll();
            Assert.AreEqual(0, allStylists.Count);
        }

        [TestMethod]
        public void GetAllAndSave_AtClientToDB_2()
        {
            Client testClient = new Client("Frye" "pjf@planetexpress.earth", "9176763486");
            testClient.Save(0);

            Client testClient2 = new Client("Hermes", "hermes@planetexpress.earth", "9173838448");
            testClient2.Save(1);

            List<Client> allClients= Client.GetAll();
            Assert.AreEqual(2, allClients.Count);
        }
    }
}
