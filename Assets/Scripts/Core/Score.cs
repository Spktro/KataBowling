using System.Collections.Generic;

  public class Score
    {
        private const int STANDARD_NUMBER_OF_THROWS = 20;
        private const int STRIKE_POINTS = 10;
        private const int SPARE_POINTS = 10;
        public int Points { get; set; }

        public Score()
        {
            Points = 0;
        }

        public void AddGame(List<int> listOfThrows)
        {
            for (int i = 0; i < listOfThrows.Count; i += 2)
            {
                int partialSum = 0;
                if (i < STANDARD_NUMBER_OF_THROWS)
                {
                    if (listOfThrows[i] == STRIKE_POINTS)
                    {
                        partialSum = AddStrikePoints(listOfThrows, i);
                    }
                    else
                    {
                        partialSum = listOfThrows[i] + listOfThrows[i + 1];
                        if (partialSum == SPARE_POINTS)
                        {
                            // spare
                            partialSum += listOfThrows[i + 2];
                        }
                    }
                }
              
                Points += partialSum;
            }
        }

        private static int AddStrikePoints(List<int> listOfThrows, int i)
        {
            return listOfThrows[i] + listOfThrows[i + 2] + listOfThrows[i + 3];
        }
    }
