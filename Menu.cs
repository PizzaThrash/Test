using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.P))
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
        if (Input.GetKeyDown (KeyCode.R))
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        if (Input.GetKeyDown (KeyCode.Q))
        Debug.Log("Quit");
        Application.Quit();
    }
     
    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Quit ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
