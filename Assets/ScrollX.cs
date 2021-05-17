using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollX : MonoBehaviour
{
    public float speedX = -1;
   

    // Update is called once per frame
    void Update()
    {
        
        // ¹æ¹ý 1
       transform.Translate(speedX * Time.deltaTime, 0, 0);

        //var pos = transform.position;
        //pos.x += speedX * Time.deltaTime;
        //transform.position = pos;
    }
}
