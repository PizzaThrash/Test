using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.M))
        SceneManager.LoadScene("menu");

    }
//    public void restart ()
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildindex);
//    }

    public void Menu (string menu)
    {
        Debug.Log("Menu");
        SceneManager.LoadScene("menu");
    }

}
