using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Utils
    {
        public static bool ThrowListIsValid(List<int> listOfThrows)
        {
            bool isValid = true;
            for (int i = 0; i < listOfThrows.Count; i++)
            {
                isValid = (listOfThrows[i] + listOfThrows[i + 1]) > 10;
                if (!isValid) break;
            }
            
           return (listOfThrows.Count < 22) &&  !listOfThrows.Exists( a =>a > 10 || a < 0 ) && isValid;
        }
    }
