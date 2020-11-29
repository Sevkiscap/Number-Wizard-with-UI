using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizardD : MonoBehaviour
{
   [SerializeField] int max;
   [SerializeField] int min;
   [SerializeField] TextMeshProUGUI guessText;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
    
    Guess();


    }
    public void Guess ()
    {
      
      guess = Random.Range(min, max+1);
      guessText.text = guess.ToString();

    }


    public void PressHigher()
    {
        min = guess+1;
        Guess();
    }
    public void PressLower()
    {
        max = guess-1;
        Guess();
    }
    
}
