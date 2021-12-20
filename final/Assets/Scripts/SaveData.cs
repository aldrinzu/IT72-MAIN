using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public InputField email;
    public InputField username;
    public InputField password;

    public void clickSignUp()

    {
       

           // ISEMPTY PO DAPAT TO HEHEH 
        if (email.text == "")
        {
            Debug.Log("Please input email");

        }

        else if (username.text == "")
        {
            Debug.Log("Please input username");

        }

        else if (password.text == "")
        {
            Debug.Log("Please input password");

        }

        else
        {
            PlayerPrefs.SetString("email", email.text);
            PlayerPrefs.SetString("username", username.text);
            PlayerPrefs.SetString("password", password.text);
            SceneManager.LoadScene("Login");

        }

    }

}
