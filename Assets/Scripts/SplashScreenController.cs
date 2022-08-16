using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenController : MonoBehaviour
{
    public GameObject splashScreen;
    public GameObject mainMenu;
    void Update()
    {
        Invoke("showMenu", 6f);
    }

    public void showMenu()
    {
        splashScreen.SetActive(false);
        mainMenu.SetActive(true);
    }
}
