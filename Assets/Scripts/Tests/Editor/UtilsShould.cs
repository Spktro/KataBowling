using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class UtilsShould
{
    // A Test behaves as an ordinary method
    [Test]
    public void ReturnFalseWhenMoreThan22Throws()
    {
        // Given - Arrange
        Score score = new Score();
        List<int> ListOfThrowsNonStrikeOrSpares = new List<int>()
        {
            5, 3,
            6, 0,
            7, 2,
            6, 0,
            3, 0,
            2, 0,
            4, 1,
            1, 7,
            0, 2,
            3, 1,
            4, 2,
            4
        };
        // When - Act 
        // Then - Assert

        Assert.AreEqual(false, Utils.ThrowListIsValid(ListOfThrowsNonStrikeOrSpares));
    }


    [Test]
    public void ReturnFalseWhenThrowPinsAreGreaterThanTen()
    {
        // Given - Arrange

        Score score = new Score();
        List<int> ListOfThrowsNonStrikeOrSpares = new List<int>()
        {
            5, 3,
            6, 0,
            7, 2,
            6, 0,
            3, 0,
            2, 0,
            14, 1,
            1, 7,
            0, 2,
            3, 1
        };

        // Then - Assert
        Assert.AreEqual(false, Utils.ThrowListIsValid(ListOfThrowsNonStrikeOrSpares));
    }

    [Test]
    public void ReturnFalseWhenSumOfThrowsInSameTurnAreGreaterThanTen()
    {
        // Given - Arrange

        Score score = new Score();
        List<int> ListOfThrowsNonStrikeOrSpares = new List<int>()
        {
            5, 5,
            6, 0,
            7, 2,
            6, 0,
            3, 0,
            2, 0,
            1, 1,
            1, 7,
            0, 2,
            3, 1
        };
        // Then - Assert
        Assert.AreEqual(false, Utils.ThrowListIsValid(ListOfThrowsNonStrikeOrSpares));
    }
}