using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;
    
    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        Debug.Log ("LEVEL COMPLETED!");
    }

    public float delayed = 2f;
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("retry");
            Invoke ("retry",delayed);
            SceneManager.LoadScene("retry");
        }
    }

    // Triggers a delayed restart
    // public float restartDelay = 1f;
    // public void EndGame ()
    // {
    //     if (gameHasEnded == false)
    //     {
    //         gameHasEnded = true;
    //         Debug.Log("GAME OVER");
    //         Invoke("Restart",restartDelay);
    //     }
    // }

    // Restarts the actual level
    // void Restart ()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    // }

}
