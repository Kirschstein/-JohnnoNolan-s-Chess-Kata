using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ChessKata
{
    public class ChessPiece
    {
        public string Colour { get; set; }
        public string Name { get; set; }
        private IChessPieceRule _pieceRules;

        public ChessPiece(string colour, string pieceName, IChessPieceRule pieceRules)
        {
            Colour = colour;
            Name = pieceName;
            _pieceRules = pieceRules;
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Colour, Name);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public bool IsValidMove(Square currentSquare, 
                                Square destinationSquare, 
                                bool isCapture)
        {

            return _pieceRules.IsValidMove(currentSquare, destinationSquare, isCapture);
        }
    }

}
