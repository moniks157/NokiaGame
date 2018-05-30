using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouseLook : MonoBehaviour {

    Vector2 mouseLook;
    Vector2 smoothlV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject character;

	void Start () {
        character = this.transform.parent.gameObject;
	}
	
	void Update () {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothlV.x = Mathf.Lerp(smoothlV.x, md.x, 1f / smoothing);
        smoothlV.y = Mathf.Lerp(smoothlV.y, md.y, 1f / smoothing);
        mouseLook += smoothlV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -75f, 80f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}
