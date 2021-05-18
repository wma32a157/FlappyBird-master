using UnityEngine;

public class bird : MonoBehaviour
{
    new public Rigidbody2D rigidbody2D;
    public new Animator animator;
    public void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }


    public float forceY = 100;
    void Update()
    {
        // Mouse Use or Space key Ues
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (Time.time < 0.7f)
            {
                Vector2 force;
                force.x = 0;
                force.y = forceY;
                rigidbody2D.AddForce(force);
                //rigidbod2D // 낙하중 -> 멈추고 나서 -> 힘을 줘야 force적용됨
                rigidbody2D.velocity = Vector2.zero;// new Vector2
                rigidbody2D.AddForce(force);

                //날개 펄럭
                animator.Play("Flap", 0, 0);

                // 스크롤 하는 것들 다 멈추자
                GameManager.instace.scrollSpeedXMuItiply = 0;

            }
        }



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Bird Died
        //죽는 애니메이션 
        animator.Play("Die", 0, 0);

        // 게임 오버 UI 표시
        GameManager.instace.ShowGameOver(true);

        // 스크롤 하는 것들 멈추기

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instace.AddScore();
    }

}
