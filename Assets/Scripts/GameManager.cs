using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject VoiceButton;

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void OnPlay()
    {
        PlayButton.SetActive(false);
        VoiceButton.SetActive(false);
        Time.timeScale = 1f;
    }

}
