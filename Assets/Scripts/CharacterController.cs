using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour {
    public float speed = 10f;
    public static int HEALTH = 20;

	void Start () {

        //Cursor.lockState = CursorLockMode.Locked;
    }
	
	void Update () {

        
        if(HEALTH == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
        }

        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
	}
}
