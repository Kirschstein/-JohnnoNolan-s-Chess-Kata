using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ChessKata
{
    public class ChessBoard
    {
        public string PlayerMessage { get; private set; }
        private Dictionary<Square, ChessPiece> _pieceLocations =
            new Dictionary<Square, ChessPiece>();

        public ChessBoard(string columns, string rows)
        {
            GenerateBoard(columns, rows);
        }

        private void GenerateBoard(string columns, string rows)
        {
            foreach (var column in columns.ToCharArray())
            {
                foreach (var row in rows.ToCharArray())
                {
                    var square = new Square(column, row);
                    _pieceLocations.Add(square, null);
                }
            }
        }

        public void PlacePiece(ChessPiece piece, Square square)
        {
            _pieceLocations[square] = piece;
        }

        public ChessPiece GetPiece(Square square)
        {
            return _pieceLocations[square];
        }

        public void MovePiece(Square startingSquare, Square destinationSquare)
        {
            if (IsOutOfBounds(startingSquare, destinationSquare))
            {
                PlayerMessage = "Illegal Move";
                return;
            }



            var piece = _pieceLocations[startingSquare];
            var otherPiece = _pieceLocations[destinationSquare];


            if (otherPiece != null && !IsCapture(piece,otherPiece))
            {
                PlayerMessage = "Illegal Move";
                return;
            }



            if (piece.IsValidMove(startingSquare, destinationSquare, IsCapture(piece, otherPiece)))
            {
                _pieceLocations[startingSquare] = null;

                this.PlayerMessage = string.Format("{0} to {1}", piece.Name, destinationSquare);

                if(IsCapture(piece, otherPiece))
                    this.PlayerMessage += string.Format(". {0} takes {1}", piece.Name, otherPiece.Name);

                _pieceLocations[destinationSquare]  = piece;
            }
            else
                PlayerMessage = "Illegal Move";

        }

        private bool IsCapture(ChessPiece movingPiece, ChessPiece otherPiece)
        {
            if (otherPiece == null)
                return false;

            return otherPiece.Colour != movingPiece.Colour;
        }

        private bool IsOutOfBounds(Square startingSquare, Square destinationSquare)
        {
            return !_pieceLocations.ContainsKey(destinationSquare);
        }
    }
}