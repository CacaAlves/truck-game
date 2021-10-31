using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginUIController : MonoBehaviour
{
    [SerializeField]
    private InputField[] loginInputFields;
    
    [SerializeField]
    private Text iniciarButtonTxt;

    // Update is called once per frame
    void Update()
    {
        foreach (InputField input in loginInputFields) 
        {
            if (input.isFocused) iniciarButtonTxt.text = "Iniciar";

        }
    }
}
