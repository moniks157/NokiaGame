using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    float enemies;
    public GameObject enemy;

	void Start () {
        enemies = ValueHandler.ENEMIES;

        for (int i = 0; i < enemies; i++)
        {
            Vector3 rand = Randomize();
            Instantiate(enemy, rand, Quaternion.identity);
        }
	}

    private Vector3 Randomize()
    {
        return new Vector3(Random.Range(-24f, 24f), 10f, Random.Range(-24f, 24f));
    }
}
