using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueHandler : MonoBehaviour {
    Text textComponent;
    public static float ENEMIES = 1f;
	// Use this for initialization
	void Start () {
        textComponent = GetComponent<Text>();
    }

    public void SetSliderValue(float sliderValue)
    {
        ENEMIES = sliderValue;
        textComponent.text = sliderValue.ToString();
    }
}
