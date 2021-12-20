using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class ForgotPassword : MonoBehaviour
{
    public InputField emailinput;

    // Start is called before the first frame update
    void Start()
    {


        
        PlayerPrefs.SetString("emailinput", emailinput.text);

    }

    public void ShowPassword()

    {
        if (emailinput.text == PlayerPrefs.GetString("email"))
        {
            Debug.Log("Your password is " + PlayerPrefs.GetString("password"));

        }
        else
        {
            Debug.Log("Email not existing");

        }

    }


    public void BacktoLogin()

    {
        SceneManager.LoadScene("Login");

    }
}
