using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Shop;
    public GameObject Privacy;

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Main()
    {
        Mainmenu.SetActive(true);
    }
    public void NoMain()
    {
        Mainmenu.SetActive(false);
    }
    
   
    public void ONShop()
    {
        Shop.SetActive(true);
    }
    public void NoShop()
    {
        Shop.SetActive(false);
    }
    public void PrivacyOn()
    {
        Privacy.SetActive(true);
    }
    public void PrivacyOfff()
    {
        Privacy.SetActive(false);
    }

}
