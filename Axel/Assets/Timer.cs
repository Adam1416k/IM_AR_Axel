using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private DateTime targetDate;
    private TimeSpan timeRemaining;

    void Start()
    {
        // Load the target date from PlayerPrefs
        string dateString = PlayerPrefs.GetString("TargetDate");
        if (!string.IsNullOrEmpty(dateString))
        {
            targetDate = DateTime.Parse(dateString);
        }
        else
        {
            // Set the target date to 6 days from now
            targetDate = DateTime.Now.AddDays(6);
            // Save the target date to PlayerPrefs
            PlayerPrefs.SetString("TargetDate", targetDate.ToString());
            PlayerPrefs.Save();
        }

        // Calculate the time remaining
        timeRemaining = targetDate - DateTime.Now;
    }

    void Update()
    {
        // Update the time remaining every frame
        timeRemaining = targetDate - DateTime.Now;
        Debug.Log("Time remaining: " + timeRemaining.ToString());
    }
}