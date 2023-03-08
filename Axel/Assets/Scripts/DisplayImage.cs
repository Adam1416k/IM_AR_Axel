using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayImage : MonoBehaviour
{
    public Texture2D imageToDisplay;
    public RawImage rawImage;

    void Start()
    {
        rawImage.enabled = false;
    }

    public void OnButtonClick()
    {
        rawImage.enabled = true;
        rawImage.texture = imageToDisplay;
        Debug.Log("Button clicked!");

    }
}