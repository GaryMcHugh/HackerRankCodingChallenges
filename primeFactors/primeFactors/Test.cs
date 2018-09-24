using System;
using NUnit.Framework;

namespace ConsoleApp1
{
    public class Test
    {
        [Test]
        public void Factoral()
        {
            Assert.AreEqual(1,Factoral(1));
        }

        private double Factoral(int v)
        {
            return 1;
        }
    }
}
