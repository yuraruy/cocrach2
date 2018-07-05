using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROT : MonoBehaviour {
    public float min = -0.30f;
    public float max = 0.30f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	// Update is called once per frame
	void Update () {
        Quaternion rotation = GetComponent<Transform>().rotation;
        rotation.z = Mathf.Clamp(rotation.z,min, max);
        GetComponent<Transform>().rotation = rotation;
        print(rotation.z);
    }
}
