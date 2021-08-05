using System;
using System.Collections.Generic;
using BowlingGame;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{

  [SerializeField] private Button _calculateScoreButton;
  [SerializeField] private InputField _throw11;
  [SerializeField] private InputField _throw12;
  [SerializeField] private InputField _throw21;
  [SerializeField] private InputField _throw22;
  [SerializeField] private InputField _throw31;
  [SerializeField] private InputField _throw32;
  [SerializeField] private InputField _throw41;
  [SerializeField] private InputField _throw42;
  [SerializeField] private InputField _throw51;
  [SerializeField] private InputField _throw52;
  [SerializeField] private InputField _throw61;
  [SerializeField] private InputField _throw62;
  [SerializeField] private InputField _throw71;
  [SerializeField] private InputField _throw72;
  [SerializeField] private InputField _throw81;
  [SerializeField] private InputField _throw82;
  [SerializeField] private InputField _throw91;
  [SerializeField] private InputField _throw92;
  [SerializeField] private InputField _throw101;
  [SerializeField] private InputField _throw102;
  [SerializeField] private InputField _throw103;
  [SerializeField] private Text _scoreText;

    private Score _score;
    private List<int> listOfThrows;
    
    private void Start()
    {
        _calculateScoreButton.onClick.AddListener(CalculateScore);
    }

    private void CalculateScore()
    {
        _score = new Score();
        listOfThrows =  GetListOfThrowsFromUI();
        _score.AddGame(listOfThrows);
        _scoreText.text = _score.Points.ToString();
    }


    private List<int> GetListOfThrowsFromUI()
    {
        List<int> listOfThrows = new List<int>();
        listOfThrows.Add(Int32.Parse(_throw11.text)) ;
        listOfThrows.Add(Int32.Parse(_throw12.text)) ;
        listOfThrows.Add(Int32.Parse(_throw21.text)) ;
        listOfThrows.Add(Int32.Parse(_throw22.text)) ;
        listOfThrows.Add(Int32.Parse(_throw31.text)) ;
        listOfThrows.Add(Int32.Parse(_throw32.text)) ;
        listOfThrows.Add(Int32.Parse(_throw41.text)) ;
        listOfThrows.Add(Int32.Parse(_throw42.text)) ;
        listOfThrows.Add(Int32.Parse(_throw51.text)) ;
        listOfThrows.Add(Int32.Parse(_throw52.text)) ;
        listOfThrows.Add(Int32.Parse(_throw61.text)) ;
        listOfThrows.Add(Int32.Parse(_throw62.text)) ;
        listOfThrows.Add(Int32.Parse(_throw71.text)) ;
        listOfThrows.Add(Int32.Parse(_throw72.text)) ;
        listOfThrows.Add(Int32.Parse(_throw81.text)) ;
        listOfThrows.Add(Int32.Parse(_throw82.text)) ;
        listOfThrows.Add(Int32.Parse(_throw91.text)) ;
        listOfThrows.Add(Int32.Parse(_throw92.text)) ;
        listOfThrows.Add(Int32.Parse(_throw101.text)) ;
        listOfThrows.Add(Int32.Parse(_throw102.text)) ;
    //    listOfThrows.Add(Int32.Parse(_throw103.text)) ;
        return listOfThrows;
    }
}
