using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public int FirstPlayerScore;
    public int SecondPlayerScore;

    void Update()
    {
        if(FirstPlayerScore == 10 || SecondPlayerScore == 10)
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 0f;
        }

        scoreText.text = "SCORE     " + FirstPlayerScore + " - " + SecondPlayerScore;
    }
}
