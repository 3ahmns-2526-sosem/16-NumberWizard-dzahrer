using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Number Range")]
    [SerializeField] private int min = 1;
    [SerializeField] private int max = 100;

    [Header("UI")]
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

    private void CalculateGuess()
    {
        guess = (min + max) / 2;

        if (guessText != null)
        {
            guessText.text = guess.ToString();
        }
    }
}