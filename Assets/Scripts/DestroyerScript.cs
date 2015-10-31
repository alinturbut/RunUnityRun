using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void onTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Break();
        }

        if(other.gameObject.transform.parent)
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
