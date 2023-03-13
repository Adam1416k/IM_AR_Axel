using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public TextMesh textMesh; // Reference to the Text Mesh component
    public string originalText; // The original text that was in the Text Mesh component

    private DateTime endDate; // Date and time when the timer should end

    void Start()
    {
        // Load the end date from the PlayerPrefs if it exists, otherwise set it to 3 days from now
        if (PlayerPrefs.HasKey("endDate"))
        {
            string endDateString = PlayerPrefs.GetString("endDate");
            endDate = DateTime.Parse(endDateString);
        }
        else
        {
            endDate = DateTime.Now.AddDays(3);
            PlayerPrefs.SetString("endDate", endDate.ToString());
        }

        // Store the original text of the Text Mesh component
        originalText = textMesh.text;
    }

    void Update()
    {
        // Calculate the time remaining until the end date
        TimeSpan timeRemaining = endDate - DateTime.Now;

        // If the timer has run out, set the text to indicate that
        if (timeRemaining.TotalSeconds <= 0)
        {
            textMesh.text = "Dags att vattna igen";
            return;
        }

        // Otherwise, format the time remaining as a string and append it to the original text
        string timeRemainingString = string.Format("{0} dagar, {1:D2}:{2:D2}:{3:D2}",
            (int)timeRemaining.TotalDays,
            timeRemaining.Hours,
            timeRemaining.Minutes,
            timeRemaining.Seconds);
        textMesh.text = originalText + " " + timeRemainingString;
    }

    void OnApplicationPause(bool pauseStatus)
    {
        // If the app is being paused, save the end date to PlayerPrefs
        if (pauseStatus)
        {
            PlayerPrefs.SetString("endDate", endDate.ToString());
        }
    }
}