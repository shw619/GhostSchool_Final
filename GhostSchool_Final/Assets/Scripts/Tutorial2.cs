using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    public GameObject Lock;
    public GameObject lastpanel;


    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && Input.GetKey(KeyCode.Space))
        {
            Lock.SetActive(true);
            Destroy(Lock, 1.5f);
            Invoke("lasttutorial", 2f);
        }

    }

    void lasttutorial()
    {
        lastpanel.SetActive(true);
    }
}
