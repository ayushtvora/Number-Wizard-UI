using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int guess;

    [SerializeField] private TextMeshProUGUI guessText;
    [SerializeField] private int max;

    [SerializeField] private int min;

    // Start is called before the first frame update
    private void Start()
    {
        Guess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        Guess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        Guess();
    }

    private void Guess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}