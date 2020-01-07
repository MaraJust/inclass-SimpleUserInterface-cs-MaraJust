using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text CountdownText;
    public Button AddOneButton;

    public void Start()
    {
        CountdownText.text = "0";
    }
    public void addOne()
    {
        int addNumbers = int.Parse(CountdownText.text) + 1;
        CountdownText.text = addNumbers.ToString();
    }



}
