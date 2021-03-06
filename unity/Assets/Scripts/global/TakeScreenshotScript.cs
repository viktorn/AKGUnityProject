using UnityEngine;
using System.Collections;
 
public class TakeScreenshotScript : MonoBehaviour
{    
    int screenshotCount = -1;
 		
    // Check for screenshot key each frame
    void Update()
    {
        // take screenshot on up->down transition of F9 key
        if (Input.GetKeyDown("f1"))
        {        
            string screenshotFilename;
            do
            {
                screenshotCount++;
                screenshotFilename = "screenshot" + screenshotCount + ".png";
 
            } while (System.IO.File.Exists(screenshotFilename));
 
            Application.CaptureScreenshot(screenshotFilename);
        }
    }
}