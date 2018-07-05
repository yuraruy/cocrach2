using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StenaChisla : MonoBehaviour
{
    public GameObject inf, obji;
    bool g = false;
    int U = 0;
    float impulse = 2f;

    void Update()
    {
        if (GetComponent<Text>().text == "12")
        {
            Destroy(obji);
            U = 1;
        }

        if (U == 1)
        {
            inf.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, impulse * impulse*Time.deltaTime));
        }
    }











    //private void Run()
    //{
     //   float speder = 10.0f * Time.deltaTime;
     //  for (int i = 1; i <= 10000; i++)
//{
   //         print(i);
       //     new WaitForSeconds(1);
     //       inf.transform.Translate(1.0f, 0, 0);
     //  // }
//    }
}