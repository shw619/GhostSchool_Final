using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOpen : MonoBehaviour
{
    public GameObject Locker;


    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && Input.GetKey(KeyCode.Space))
        {
            if(Locker != null)
            Locker.SetActive(true);
            Invoke("lockClose", 5.5f);
        }

    }

    void lockClose()
    {
        Locker.SetActive(false);
    }

}



