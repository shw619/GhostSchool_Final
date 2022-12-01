using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject Panel;
    public GameObject Ghost;
    public GameObject a;
    public AudioSource audioSource;

    float speed;
    float moveX;
    float moveY;

    [SerializeField]
    float normalSpeed;
    [SerializeField]
    float runSpeed;
    [SerializeField]
    float ghostSpeed;

    bool canMove = true;

    Animator anim;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Awake()
    {
        anim = GetComponent<Animator>(); 
    }
    void Update()
    {
        if(canMove)
            Movement();

        if(normalSpeed == 0)
        {
            anim.SetBool("isWalking", false);
        }

        if (normalSpeed == 1)
        {
            Invoke("CommonMovement", 5f);
        }


    }

    public void FixMove()
    {
        normalSpeed = 0;
        runSpeed = 0;
        canMove = false;
    }

    void Movement()
    {

        float key = Input.GetAxis("Horizontal");
        float amtMove = speed * Time.smoothDeltaTime;


        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
            anim.SetBool("isRunning", true);
        }

        else
        {
            speed = normalSpeed;
            anim.SetBool("isRunning", false);
        }


        if (key < 0)
        {
            //왼쪽 이동
            Vector3 scale = transform.localScale;
            scale.x = -Mathf.Abs(scale.x);
            transform.localScale = scale;

            transform.Translate(Vector3.right * amtMove * key);
            anim.SetBool("isWalking",true);
        }
        else if (key > 0)
        {
            //오른쪽이동
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Abs(scale.x);
            transform.localScale = scale;

            transform.Translate(Vector3.right * amtMove * key);
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

    }

    public void CommonMovement()
    {
        normalSpeed = 3;
        runSpeed = 5;

        canMove = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Panel.SetActive(true);
        }


        if (collision.gameObject.CompareTag("Ghost"))
        {
           
           normalSpeed = 1;
           runSpeed = 0;

           Destroy(Ghost,5f);
        }

        if (collision.gameObject.CompareTag("Celling"))
        {
            runSpeed = 3;
            Invoke("CommonMovement", 5f);

            Destroy(collision.gameObject,5f);
        }

    }



}





