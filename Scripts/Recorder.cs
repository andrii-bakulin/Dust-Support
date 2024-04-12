using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
    private int frameIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SaveCameraView(Camera.main);

        if (frameIndex == 900)
            Debug.LogError("Done");
    }

    void SaveCameraView(Camera cam)
    {
        /*
        int W = 1920/2; // Screen.width
        int H = 1080/2; // Screen.height

        RenderTexture screenTexture = new RenderTexture(W, H, 16);
        cam.targetTexture = screenTexture;
        RenderTexture.active = screenTexture;
        cam.Render();

        Texture2D renderedTexture = new Texture2D(W, H);
        renderedTexture.ReadPixels(new Rect(0, 0, W, H), 0, 0);
        RenderTexture.active = null;

        byte[] byteArray = renderedTexture.EncodeToPNG();
        System.IO.File.WriteAllBytes(Application.dataPath + "/../_ScreenShots/frame"+(frameIndex++)+".png", byteArray);
        */
        
        ScreenCapture.CaptureScreenshot(Application.dataPath + "/../_ScreenShots2/frame"+(frameIndex++)+".png");
    }
}
