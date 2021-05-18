using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePhyBird : bird
{
    new private void Start()
    {
        base.Start();

        // 인스펙터에서 했다면 아래 코드 적을 필요 없다.
        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;
        rigidbody2D.useFullKinematicContacts = true;
    }
    public float gravity = -9.8f;
    public float acceleration;

    private void Update()
    {
        acceleration = gravity * Time.deltaTime;
        // 중력에 의한 낙하 구현
        // 중력.
        // 중력 가속도


        // y 값 변경.
        transform.Translate(0, acceleration, 0);

    }



}
