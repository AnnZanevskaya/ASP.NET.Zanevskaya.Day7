using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3.Library;
using System.Collections.Generic;

namespace Task3.Test
{
    [TestClass]
    public class CustomQueueTest
    {
        [TestMethod]
        public void CustomQueue_UsualDate_EnqueueTest()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Enqueue(1);
            queue.Enqueue(2);

            Assert.AreEqual(2, queue.Count);
        }
        [TestMethod]
        public void CustomQueue_UsualDaten_DequeueTest()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.Dequeue();

            Assert.AreEqual(0, queue.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CustomQueue_Exeption_DequeueTest()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
        }
        [TestMethod]
        public void CustomQueue_Foreach_Test()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Enqueue(1);
            queue.Enqueue(2);
            int count = 0;
            foreach (var item in queue)
            {
                count++;
            }
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void CustomQueue_Peek_Test()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Enqueue(1);
            queue.Enqueue(2);

            var item = queue.Peek();

            Assert.AreEqual(1, item);
        }
    }
}
