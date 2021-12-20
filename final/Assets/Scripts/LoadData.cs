using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour
{

  
    public InputField usernameinput;
    public InputField passwordinput;

   


    void Start()
    {

        PlayerPrefs.SetString("usernameinput", usernameinput.text);
        PlayerPrefs.SetString("passwordinput", passwordinput.text);

 

    }


    public void clickLogin()
    {
       




        if  (usernameinput.text == PlayerPrefs.GetString("username") && passwordinput.text == PlayerPrefs.GetString("password"))
        {
            Debug.Log("Succesfully Login");

        }

        else
        {
            Debug.Log("Invalid Credentials!");

        }

    }
    public void clickForgot()
    {

        SceneManager.LoadScene("ForgotPassword");

    }




}
