using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repos : MonoBehaviour
{
    public float minX; // �̰� ���� ��ġ X�� �۾����� ���������� ����

    
    void Update()
    {
     if(minX > transform.position.x)
        {
            // ������ ���� ũ�� * 2��ŭ ����
            // ���� ũ�� 20.48
            transform.Translate(20.48f * 2, 0, 0);
        }
    }
}
