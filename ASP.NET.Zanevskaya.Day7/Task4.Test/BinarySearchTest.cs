using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4.Library;

namespace Task4.Test
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void BinarySearch_UsualDateInt_Test()
        {
            int[] numbers = { -12, 0, 23, 24, 345 };
            int expected = 0;

            Assert.AreEqual(expected, BinarySearch.Binary(numbers, -12));
        }
        [TestMethod]
        public void BinarySearch_ReturnFalseInt_Test()
        {
            int[] numbers = { -12, 0, 23, 24, 345 };
            int expected = -1;

            Assert.AreEqual(expected, BinarySearch.Binary(numbers, -13));
        }
        [TestMethod]
        public void BinarySearch_UsualDateString_Test()
        {
            string[] dinosaurs = {"Amargasaurus", 
                                "Pachycephalosaurus", 
                              "Tyrannosaurus", 
                              "Mamenchisaurus", 
                              "Deinonychus", 
                              "Edmontosaurus"};
            int expected = 0;

            Assert.AreEqual(expected, BinarySearch.Binary(dinosaurs, "Amargasaurus"));
        }
        [TestMethod]
        public void BinarySearch_ReturnFalseIString_Test()
        {
            
            string[] dinosaurs = {"Amargasaurus", 
                                "Pachycephalosaurus", 
                              "Tyrannosaurus", 
                              "Mamenchisaurus", 
                              "Deinonychus", 
                              "Edmontosaurus"};
            int expected = -1;

            Assert.AreEqual(expected, BinarySearch.Binary(dinosaurs, "13"));
        }
    }
}
