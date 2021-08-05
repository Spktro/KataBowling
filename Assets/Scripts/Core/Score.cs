using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
    public class Score
    {
        public int Points { get; set; }

        public Score()
        {
            Points = 0;
        }

        public void AddBowlingPins(int bowlingPins)
        {
            Points += bowlingPins;
        }       

        public void  AddGame(List<int> listOfThrows)
        {
            // caso spare
            for (int i = 0; i < listOfThrows.Count; i+=2)
            {
                int partialSum;
                if (listOfThrows[i] == 10)
                {
                    partialSum = AddStrikePoints(listOfThrows, i);
                }
                else
                {
                    partialSum = listOfThrows[i] + listOfThrows[i + 1];
                    if (partialSum == 10)
                    { // spare
                        partialSum += listOfThrows[i + 2];
                    }
                }
                Points += partialSum; 
            }
            
        }

        private void AddStrikePoints2(ref int sum, int p)
        {
            sum = sum + p;
        }

        private static int AddStrikePoints(List<int> listOfThrows, int i)
        {
            return listOfThrows[i] + listOfThrows[i + 2] + listOfThrows[i + 3];
        }
    }
}