using UnityEngine;
using System.Collections;

public class GroundSpawnScript : MonoBehaviour {

    public GameObject[] obj;
    public float minSpawnInterval;
    public float maxSpawnInterval;

    void Start()
    {
        Spawn();
    }

	void Spawn() {
        Instantiate(obj[Random.RandomRange(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnInterval, maxSpawnInterval));
	}
}
