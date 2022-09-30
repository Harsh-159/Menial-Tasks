using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameLogic : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void Ma()
    {
        Debug.Log("HI");
        SceneManager.LoadScene(1);
    }
    public void Story()
    {
        SceneManager.LoadScene(2);
    }
    public void Killed()
    {
        SceneManager.LoadScene(4);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void HT()
    {
        SceneManager.LoadScene(3);
    }
}
