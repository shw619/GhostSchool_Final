using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellingJumpscare : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Panel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D o)
    {
        if (o.gameObject.tag == "Player")
        {
            Panel.SetActive(true);
            //Destroy(Panel, 1f);


        }

    }

}


