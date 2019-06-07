using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {

    Renderer renderer;
    // Use this for initialization
    void Start () {
        renderer = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            renderer.material.color = Color.red;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            renderer.material.color = Color.green;
        }
    }

    private void OnTriggerStay(UnityEngine.Collider other)
    {
        float lerp = Mathf.PingPong(Time.time, 1) / 1;
        renderer.material.color = Color.Lerp(Color.red, Color.green, lerp);
    }


}
