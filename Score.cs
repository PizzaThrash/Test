using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
            scoreText.text = player.position.z.ToString("0"); // ToString is needed to convert number into text (inside " " you can add how many decimals you want.)
    }
}
