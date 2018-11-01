using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}
	
    void StartGame()
    {
        NextGuess();
        guessText.text = guess.ToString();
        max = max + 1;
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
        guessText.text = guess.ToString();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
        guessText.text = guess.ToString();
    }
    
    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}
