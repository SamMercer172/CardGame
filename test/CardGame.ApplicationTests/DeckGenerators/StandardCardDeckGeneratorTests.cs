using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGame.Application.DeckGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Domain.Entities.Cards.StandardCards;

namespace CardGame.Application.DeckGenerators.Tests
{
    [TestClass()]
    public class StandardCardDeckGeneratorTests
    {
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(10)]
        [DataRow(22)]
        [TestMethod()]
        public void GenerateDecksTest(int numberOfDecks)
        {
            int ExpectedCards = 52 * numberOfDecks;

            ICollection<StandardCard> generatedDecks = StandardCardDeckGenerator.GenerateDecks(numberOfDecks);           

            Assert.AreEqual(ExpectedCards, generatedDecks.Count());
        }
    }
}