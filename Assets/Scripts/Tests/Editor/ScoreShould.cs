using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace BowlingGame.Tests
{
    public class ScoreShould
    {
        // Enunciado Tiradas [20] [21] [22]
        // Dado una secuencia válida de tiradas de bolos,
        // devolver la puntuación total de la partida.

        // *  Si bolos de turno < 10, puntuación total  = bolos tirados. 
        // *  Si en un turno el jugador tira los 10 bolos(un "spare"), 
        // * "spare"  puntuación (10) + bolos tirados en la siguiente tirada(del siguiente turno).

        // * (un "strike") el turno acaba y la puntuación es 10 + bolos de las dos tiradas siguientes.

        // Puntuacion - Puntaje | Sumar(Tirada)


        // *  Si bolos de turno < 10, puntuación total  = bolos tirados. 

        

        [SetUp]
        public void Setup()
        {
            //Given -  Arrange
            


            

        }

        [Test]        
        public void BeTheSumOfPinsOfAllTrysIfNonStrikesOrSpareWhereMade()
        {
         
            // Given - Arrange
            Score score = new Score();
            List<int> ListOfThrowsNonStrikeOrSpares = new List<int>()
            {
                5,3,
                6,0,
                7,2,
                6,0,
                3,0,
                0,0,
                4,1,
                1,7,
                0,2,
                3,1,
            };

            // When - Act 
            score.AddGame(ListOfThrowsNonStrikeOrSpares);

            // Then - Assert
            Assert.AreEqual(ListOfThrowsNonStrikeOrSpares.Sum(), score.Points);
        }


        [Test]
        public void SumNextTurnThrowWhenSpareFound()
        {
            //Given -  Arrange
            List<int> ListOfThrowsWithSpares = new List<int>()
            {
                3,7,
                6,0,
                7,3,
                4,0,
                3,0,
                0,0,
                4,1,
                1,7,
                0,2,
                3,1,
            };           
            Score score = new Score();

            // When - Act 
            score.AddGame(ListOfThrowsWithSpares);

            // Then - Assert
            Assert.AreEqual(62, score.Points);
        }

        [Test]
        public void SumNextTurnTwoThrowWhenStrikesFound()
        {
            //Given -  Arrange
            List<int> ListOfThrowsWithStrikes = new List<int>()
            {
                3,6,
                10,0,
                7,1,
                4,0,
                10,0,
                0,0,
                4,1,
                10,0,
                0,2,
                3,1,
            };
            Score score = new Score();

            // When - Act 
            score.AddGame(ListOfThrowsWithStrikes);

            // Then - Assert
            Assert.AreEqual(72, score.Points);
        }

    }
}
