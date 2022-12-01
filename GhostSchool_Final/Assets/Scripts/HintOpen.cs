using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintOpen : MonoBehaviour
{
    public GameObject Hint;


    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && Input.GetKey(KeyCode.Space))
        {
            if (Hint != null)
                Hint.SetActive(true);
            Invoke("hintClose", 2.0f);
        }

    }

    void hintClose()
    {
        Hint.SetActive(false);
    }

}

