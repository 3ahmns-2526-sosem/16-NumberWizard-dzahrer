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
    [SerializeField] private TMP_Text newTEXT;
    [SerializeField] private int startMin;
    [SerializeField] private int startMax;

    [Header("Buttons")]
    [SerializeField] private Button higherButton;
    [SerializeField] private Button lowerButton;
    [SerializeField] private Button correctButton;
    [SerializeField] private int guess;

    
    private void Start()
{
    startMin = min;
    startMax = max;

    CalculateGuess();

    messageText.text = "";
}
    public void Higher()
    {
        // Zahl liegt oberhalb des aktuellen Guess
        min = guess + 1;
        CalculateGuess();
    }

    public void Lower()
    {
        // Zahl liegt unterhalb des aktuellen Guess
        max = guess - 1;
        CalculateGuess();
    }
    public void Correct()
    {
        messageText.text = "I guessed your number! -> " + guess;

        higherButton.interactable = false;
        lowerButton.interactable = false;
        correctButton.interactable = false;
    }
    private void CalculateGuess()
    {
        if (min > max)
        {
            messageText.text = "Invalid number range!";
            return;
        }
        // Binäre Suche: Mitte des aktuellen Suchbereichs
        guess = (min + max) / 2;

        guessText.text = guess.ToString();
    }
    private void Update()
    {
        newTEXT.text = "Is your number: " + guess +" ?";
    }
    public void Restart()
    {
        // Ursprünglichen Bereich wiederherstellen
        min = startMin;
        max = startMax;

        // Erfolgsmeldung ausblenden
        messageText.text = "";

        // Buttons wieder aktivieren
        higherButton.interactable = true;
        lowerButton.interactable = true;
        correctButton.interactable = true;
        // Ersten Guess neu berechnen
        CalculateGuess();
    }
}