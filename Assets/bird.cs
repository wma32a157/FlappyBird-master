using UnityEngine;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    new public Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();


    }


    public float forceY = 100;
    void Update()
    {
        // Mouse Use or Space key Ues
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Vector2 force;
            force.x = 0;
            force.y = forceY;
            rigidbody2D.AddForce(force);
        }



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Bird Died
        // ���� ���� UI ǥ��
        GameManager.instace.ShowGameOver(true);

        // ��ũ�� �ϴ� �͵� ���߱�

    }

}
