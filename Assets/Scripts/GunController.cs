using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunController : MonoBehaviour {

    public GameObject Explosion;
    private GameObject instantiatedObj;
    float killed = 0f;

    void Start () {
		
	}
	
	
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        
        if(killed == ValueHandler.ENEMIES) { SceneManager.LoadScene(2); }
	}

    private void Shoot()
    {
        RaycastHit hit;
        Vector3 rayOrigin = Camera.main.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));
        if (Physics.Raycast(rayOrigin, Camera.main.transform.forward, out hit))
            if (hit.collider != null && hit.collider.tag == "Enemy")
            {
                Destroy(hit.collider.gameObject);
                killed++;
            }
        instantiatedObj = Instantiate(Explosion, gameObject.transform.position + Vector3.forward * 0.1f, Quaternion.identity);
        Destroy(instantiatedObj, 1.5f);
    }
}
