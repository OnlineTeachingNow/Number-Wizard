using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int maxNumber;
    [SerializeField] int minNumber;
    [SerializeField] public int maxGuesses;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] TextMeshProUGUI guessNumber;
    int guess; 

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        guessNumber.text = maxGuesses.ToString();
    }
    public void OnPressHigher()
    {
        if (maxGuesses == 0)
        {
            SceneManager.LoadScene(7);
        }
        else
        {
            minNumber = guess + 1;
            NextGuess();
            maxGuesses--;
            guessNumber.text = maxGuesses.ToString();
        }
    }

    public void OnPressLower()
    {
        if (maxGuesses == 0)
        {
            SceneManager.LoadScene(7);
        }
        else
        {
            maxNumber = guess - 1;
            NextGuess();
            maxGuesses--;
            guessNumber.text = maxGuesses.ToString();
        }
    }

    void NextGuess()
    {
        guess = Random.Range(minNumber, maxNumber);
        guessText.text = guess.ToString();
    }
}
