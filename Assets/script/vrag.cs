using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : MonoBehaviour {
    public GameObject player;
    public float speed = 3.0f;
    public float objactr = 5f;

    private void OnTriggerEnter2D(Collider2D col)
    {        
            Destroy(player);
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime,0,0);


    }

}
