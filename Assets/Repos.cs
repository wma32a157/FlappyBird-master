using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repos : MonoBehaviour
{
    public float minX; // 이값 보다 위치 X가 작아지면 오른쪽으로 보냄

    
    void Update()
    {
     if(minX > transform.position.x)
        {
            // 오른쪽 가로 크기 * 2만큼 보냄
            // 가로 크기 20.48
            transform.Translate(20.48f * 2, 0, 0);
        }
    }
}
