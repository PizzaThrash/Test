using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.M))
        SceneManager.LoadScene("menu");

        if (Input.GetKeyDown (KeyCode.Q))
        Debug.Log("Quit");
        Application.Quit();
    }


    public void Menu (string menu)
    {
        Debug.Log("Menu");
        SceneManager.LoadScene("menu");
    }


    public void Quit ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
