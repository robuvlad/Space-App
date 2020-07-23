using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText = null;
    public float difficultyTime;
    public GameObject nextLevelCanvas = null;

    public void Start()
    {
        SetDifficultyTimeText();
        InvokeRepeating("DecreaseTime", 0.0f, 1.0f);
    }

    public void Update()
    {
        CheckDifficultyTime();
    }

    private void SetDifficultyTimeText()
    {
        timeText.text = difficultyTime.ToString("F0");
    }

    private void CheckDifficultyTime()
    {
        if (difficultyTime == 0)
        {
            nextLevelCanvas.SetActive(true);
            Time.timeScale = 0.0f;
            CancelInvoke();
            difficultyTime = -1.0f;
        }
    }

    private void DecreaseTime()
    {
        difficultyTime = difficultyTime - 1.0f;
        SetDifficultyTimeText();
    }


}
