using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downLimit : MonoBehaviour
{
    [SerializeField]
    GameObject celling;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag.Equals("Celling"))
        {
            celling.GetComponent<CellingGhost>().isPlayerCome = false;
        }
    }
}
