using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{

    public Text TextAusgabe;
    public InputField EingabeInputField;
    public Button DoItButton;

    public void showValue()
    {
        TextAusgabe.text = EingabeInputField.text;
    }
}
