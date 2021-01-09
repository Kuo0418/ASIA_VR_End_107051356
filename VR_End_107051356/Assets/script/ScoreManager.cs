using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    [Header("投進的分數")]
    public int scoreIn = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "乒乓球")
        {
            AddScore();
        }

        if (other.transform.root.name == "Player")
        {
            scoreIn = 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            scoreIn = 1;
        }
    }

    private void AddScore()
    {
        score += scoreIn;
        textScore.text = "Score : " + score;
    }
}
