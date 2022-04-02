using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turningSpeedChange : MonoBehaviour
{
    float sliderSenitivity = 0.1f;
    public Text timeintervalText;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(UIManager.MenyIsToggled)
        {
            return;
        }
        slider.value = CubeRotationScript.timeForOneFrame;

        CubeRotationScript.timeForOneFrame += Input.mouseScrollDelta.y*sliderSenitivity;

        if(CubeRotationScript.timeForOneFrame < 0.001)
        {
                CubeRotationScript.timeForOneFrame = 0.001f;
        }
        timeintervalText.text = "Time delay: " + CubeRotationScript.timeForOneFrame.ToString("0.000") + "s";
        

    }
}
