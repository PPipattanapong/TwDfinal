using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float startTime = 15f;
    public string sceneName;

    private float remainingTime;

    void Start()
    {
        remainingTime = startTime;
    }

    void Update()
    {
        remainingTime = Mathf.Max(remainingTime - Time.deltaTime, 0); //Decrease time

        int seconds = (int)(remainingTime % 15);

        timerText.text = $"{seconds:00}"; //Update text

        if (remainingTime == 0)
        {
            OnCountdownComplete();
        }
    }

    private void OnCountdownComplete()
    {
        SceneManager.LoadScene(sceneName);
    }
}
