using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : MonoBehaviour {
    public float speed = 3.0f;
    public GameObject player;
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="player")
                Destroy(player);
        if (col.gameObject.tag == "Stena")
                speed = -speed;
        
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime,0,0);
    }

}
