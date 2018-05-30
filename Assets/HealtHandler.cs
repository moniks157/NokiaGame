using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtHandler : MonoBehaviour {

    public Text txt;
	
	void Update () {
        txt.text = "Health: " + CharacterController.HEALTH;
	}
}
