using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ChessKata.Tests
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void SquareMinusSquareReturnsAMatrix()
        {
            var sq1 = new Square("A1");
            var sq2 = new Square("A2");
            var result = sq1 - sq2;

            Assert.That(result, Is.InstanceOf(typeof(Matrix)));
        }

        [Test]
        public void SquareA1MinusA2ReturnsARowDifferenceOfMinus1()
        {
            var sq1 = new Square("A1");
            var sq2 = new Square("A2");
            var result = sq1 - sq2;

            Assert.That(result.Row, Is.EqualTo(-1));
        }
    }
}
