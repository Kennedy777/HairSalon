using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTests
    {

        public StylistTests()
        {
            DB.DatabaseTest();
            Stylist.ClearAll();
            Client.ClearAll();
        }

        [TestMethod]
        public void GetAllAndSave_AddStylistToDB_1()
        {
            Stylist testStylist = new Stylist("Seymour Hare");
            testStylist.Save();

            List<Stylist> allStylists = Stylist.GetAll();
            Assert.AreEqual(1, allStylists.Count);
        }

        [TestMethod]
        public void Find_StylistInDB_true()
        {
            Stylist testStylist = new Stylist("Frederic");
            testStylist.Save();
            Stylist findStylist = Stylist.Find(testStylist.GetId());
            Assert.AreEqual(testStylist.GetName(), findStylist.GetName());
        }

        [TestMethod]
        public void ClearAll_ClearStylistsInDB_0()
        {
            Stylist testStylist = new Stylist("Harry Cutter");
            testStylist.Save();
            Stylist.ClearAll();
            List<Stylist> allStylists = Stylist.GetAll();
            Assert.AreEqual(0, allStylists.Count);
        }
    } 
}