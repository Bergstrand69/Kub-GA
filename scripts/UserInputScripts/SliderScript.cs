using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderScript : MonoBehaviour
{
    public Slider _slider;
    public Text _sliderText;
    
    // Start is called before the first frame update
    void Start()
    {
        _slider.onValueChanged.AddListener((v) => {
            _sliderText.text = "Tids interval: " + v.ToString("0.000") + "s";
            CubeRotationScript.timeForOneFrame = v;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
