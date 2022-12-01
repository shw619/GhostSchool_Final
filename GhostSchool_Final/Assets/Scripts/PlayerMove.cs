using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private BoxCollider2D boxcollider;
    public LayerMask layerMask; //통과 불가능한 레이어 설정

    public float speed;

    private Vector3 vector;

    public float runSpeed;
    private float applyRunSpeed;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
    }

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (speed == 0)
        {
            anim.SetBool("isWalking", false);
        }


        if(Input.GetAxisRaw("Horizontal")<0)
        {
            transform.localScale = new Vector3(-1, 1, 1);

        }
        else if(Input.GetAxisRaw("Horizontal")>0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetAxisRaw("Horizontal") !=0)
            {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                applyRunSpeed = runSpeed;
                anim.SetBool("isRunning", true);
            }
            else
            {
                applyRunSpeed = 0;
                anim.SetBool("isRunning", false);
            }

            vector.Set(Input.GetAxisRaw("Horizontal"), transform.position.y, transform.position.z);

            if(vector.x != 0)
            {
                transform.Translate(vector.x * (speed+applyRunSpeed), 0, 0);
                anim.SetBool("isWalking", true);
            }
            else
            {
                anim.SetBool("isWalking", false);
            }
        }
    }
}
