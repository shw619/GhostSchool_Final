using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject messagepanel;

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player")/* && Input.GetKey(KeyCode.Space)*/)
        {
            messagepanel.SetActive(true);


        }

    }



}

