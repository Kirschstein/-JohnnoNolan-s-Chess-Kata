using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ChessKata
{
    public class Square
    {
        private string _squareCoordinates;
        public string Column { get; private set; }
        public string Row { get; private set; }

        public Square(string squareCoordinates)
        {
            _squareCoordinates = squareCoordinates;
            Column = squareCoordinates[0].ToString();
            Row = squareCoordinates[1].ToString();
        }

        public Square(char column, char row)
        {
            _squareCoordinates = column.ToString() + row.ToString();
        }

        public override string ToString()
        {
            return _squareCoordinates;
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return ("square" + _squareCoordinates).GetHashCode();
        }

        public static Matrix operator -(Square s1, Square s2)
        {
            s1.Column.ToAsciiValue();
            return new Matrix
            {
                Column = s1.Column.ToAsciiValue() - s2.Column.ToAsciiValue(),
                Row = s1.Row.ToAsciiValue() - s2.Row.ToAsciiValue()
            };
        }
    }

    public class Matrix
    {
        public int Column { get; set; }
        public int Row { get; set; }
    }

    public static class StringExtensions
    {
        public static int ToAsciiValue(this string source)
        {
            if (source.Length != 1)
                throw new ArgumentException("Oooops, should be a single character");

            return (int)source[0];
        }
    }
}
