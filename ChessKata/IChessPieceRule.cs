using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ChessKata
{
    public interface IChessPieceRule
    {
        bool IsValidMove(Square currentSquare, Square destinationSquare, bool isCapture);
    }

    public class PawnRules : IChessPieceRule
    {
        int _directionModifier = 1;
        string _homeRow = "7";

        public PawnRules(string colour)
        {
            if (colour == "White")
            {
                _directionModifier = -1;
                _homeRow = "2";
            }                
        }

        public bool IsValidMove(Square currentSquare, Square destinationSquare, bool isCapture)
        {
            var distance = (currentSquare - destinationSquare);
            var rowDistance = distance.Row * _directionModifier;
            var columnDistance = Math.Abs(distance.Column);

            if (rowDistance == 1 || IsHomeRowMove(rowDistance, currentSquare))
            {
                if (columnDistance == 0 || (isCapture && columnDistance == 1))
                    return true;
            } 

            return false;
        }

        private bool IsHomeRowMove(int distance, Square currentSquare)
        {
            return distance == 2 && currentSquare.Row == _homeRow;
        }

    } 

    public class KnightRules : IChessPieceRule
    {
        public bool IsValidMove(Square currentSquare, Square destinationSquare, bool isCapture)
        {
            var matrix = currentSquare - destinationSquare;

            if (Math.Abs(matrix.Row) == 3 || Math.Abs(matrix.Column) == 3)
                return false;

            return (Math.Abs(matrix.Row) + Math.Abs(matrix.Column)) == 3;
        }
    }

}
