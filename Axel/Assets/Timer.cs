using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    public float timerValue = 60f;
    private TextMesh textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMesh>();
    }

    void Update()
    {
        if (timerValue > 0)
        {
            timerValue -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(timerValue / 60f);
            int seconds = Mathf.FloorToInt(timerValue - minutes * 60);
            textMesh.text = "Time: " + minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        else
        {
            textMesh.text = "Time: 00:00";
        }
    }
}