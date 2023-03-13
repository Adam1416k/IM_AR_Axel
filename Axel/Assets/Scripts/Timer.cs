using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public TextMesh textMesh; // Reference to the Text Mesh component

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
    }

    void Update()
    {
        // Calculate the time remaining until the end date
        TimeSpan timeRemaining = endDate - DateTime.Now;

        // If the timer has run out, set the text to indicate that
        if (timeRemaining.TotalSeconds <= 0)
        {
            textMesh.text = "Timer has run out!";
            return;
        }

        // Otherwise, format the time remaining as a string and set the text to display it
        string timeRemainingString = string.Format("{0} days, {1:D2}:{2:D2}:{3:D2}",
            (int)timeRemaining.TotalDays,
            timeRemaining.Hours,
            timeRemaining.Minutes,
            timeRemaining.Seconds);
        textMesh.text = timeRemainingString;
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