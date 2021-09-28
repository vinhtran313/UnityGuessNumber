using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }


    // Update is called once per frame
    private void startGame()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
        max += 1;
    }

    public void pressHigher()
    {
        min = guess;
        nextGuess();
    }
    public void pressLower()
    {
        max = guess;
        nextGuess();
    }
    private void nextGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
}
