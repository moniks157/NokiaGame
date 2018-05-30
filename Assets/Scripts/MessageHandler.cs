using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageHandler : MonoBehaviour {

    public Text txt;

	void Start () {
        //Cursor.lockState = CursorLockMode.None;
        if (CharacterController.HEALTH > 0 )
        {
            txt.text = "Congratulations";
        }
        else txt.text ="You Lost";
    }
}
