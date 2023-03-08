using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    public float startingTime = 60f; // Starting time in seconds
    private float currentTime; // Current time in seconds
    private string originalText; // Original text in the TextMesh component
    private TextMesh textMesh; // Reference to TextMesh component

    void Start()
    {
        textMesh = GetComponent<TextMesh>();
        originalText = textMesh.text;
        currentTime = PlayerPrefs.GetFloat("Timer", startingTime);
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(currentTime / 60f);
            int seconds = Mathf.FloorToInt(currentTime % 60f);
            string timerText = "Vattna inom: " + minutes.ToString("00") + ":" + seconds.ToString("00");
            textMesh.text = originalText + "\n" + timerText;
            PlayerPrefs.SetFloat("Timer", currentTime);
        }
        else
        {
            textMesh.text = originalText + "\nTime's up!";
        }
    }
}