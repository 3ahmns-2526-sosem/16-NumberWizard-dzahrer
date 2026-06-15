using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int min = 1;
    [SerializeField] private int max = 100;

    [Header("UI")]
    [SerializeField] private TMP_Text guessText;
    [SerializeField] private TMP_Text messageText;

    [Header("Buttons")]
    [SerializeField] private Button higherButton;
    [SerializeField] private Button lowerButton;
    [SerializeField] private Button correctButton;

    [SerializeField] private int guess;

    private void Start()
    {
        CalculateGuess();
        messageText.text = "";
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

    public void Correct()
    {
        messageText.text = "I guessed your number!";

        higherButton.interactable = false;
        lowerButton.interactable = false;
        correctButton.interactable = false;
    }

    private void CalculateGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
}