using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
    public Text fpsText;
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    private void Update()
    {
        float fps = 1f / Time.unscaledDeltaTime;
        fpsText.text = "FPS: " + Mathf.RoundToInt(fps);
    }
}
