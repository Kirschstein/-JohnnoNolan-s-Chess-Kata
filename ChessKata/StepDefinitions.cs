using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ChessKata
{
    [Binding]
    public class StepDefinitions
    {
        ChessBoard _board;

        [Given(@"I have an empty board")]
        public void CreateEmptyBoard()
        {
            _board = new ChessBoard("ABCDEFGH", "12345678");
        }

        [Given(@"I have a (.*) (.*) at (.*)")]
        public void AddPieceToBoard(string colour, string pieceName, string square)
        {
            var piece = CreatePiece(pieceName, colour);
            _board.PlacePiece(piece, new Square(square));
        }

        [When(@"I move (.*) to (.*)")]
        public void MovePiece(string startingSquare, string destinationSquare)
        {
            _board.MovePiece(new Square(startingSquare), new Square(destinationSquare));
        }

        [Then(@"I see the message: '(.*)'")]
        public void CorrectMessageIsShown(string message)
        {
            Assert.That(_board.PlayerMessage, Is.EqualTo(message));
        }

        [Then(@"I have a (.*) (.*) at (.*)")]
        public void PieceIsInSquare(string colour, string pieceType, string square)
        {
            var expectedPiece = CreatePiece(pieceType, colour);
            var actualPiece = _board.GetPiece(new Square(square));

            Assert.That(actualPiece, Is.EqualTo(expectedPiece));
        }

        [Then(@"I do not have a piece at (.*)")]
        public void NoPieceInSquare(string square)
        {
            Assert.That(_board.GetPiece(new Square(square)), Is.Null);
        }

        private ChessPiece CreatePiece(string name, string colour)
        {
            if (name == "Pawn")
                return new ChessPiece(colour, name, new PawnRules(colour));

            return new ChessPiece(colour, name, new KnightRules());
        }
    }
}