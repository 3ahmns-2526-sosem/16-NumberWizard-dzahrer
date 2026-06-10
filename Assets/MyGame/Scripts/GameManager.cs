using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int min = 1;
    [SerializeField] private int max = 100;
    [SerializeField] private TMP_Text guessText;

    [SerializeField] private int guess;

    private void Start()
    {
        CalculateGuess();
    }

    public void Higher()
    {
        min = guess + 1;
        CalculateGuess();
    }

    public void Lower()
    {
        max = guess - 1;
        CalculateGuess();
    }

    private void CalculateGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
}