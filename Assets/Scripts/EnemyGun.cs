using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour {
    public GameObject Projectile;
    private GameObject instantiatedObj;
    bool shooting = false;
    float time = 0f;

	void Update () {

        time += Time.deltaTime;
        if(shooting)
        {
            Shoot();
        }
        if (time > 3f)
        {
            time = 0;
            shooting = true;
        }

    }

    private void Shoot()
    {
        shooting = false;
        instantiatedObj = Instantiate(Projectile, gameObject.transform.position,gameObject.transform.parent.parent.rotation);
        Destroy(instantiatedObj, 10f);
    }

}
