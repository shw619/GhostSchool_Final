using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorGhost : MonoBehaviour
{
    Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetTrigger("jumpScare");

            Invoke("TurnPlayerCamera", 2.0f);
        }
    }

    void TurnPlayerCamera()
    {
        GameObject Camera = GameObject.Find("Main Camera");
        Camera.SendMessage("RotateCamera");
    }
}
