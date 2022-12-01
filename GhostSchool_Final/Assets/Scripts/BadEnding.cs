using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadEnding : MonoBehaviour
{

    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject sprite3;
    public GameObject sprite4;
    public GameObject sprite5;
    public GameObject sprite6;
    public GameObject sprite7;
    public GameObject sprite8;
    public GameObject sprite9;
    public GameObject sprite10;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("s2", 1f);
        Invoke("s3", 2f);
        Invoke("s4", 3f);
        Invoke("s5", 4f);
        Invoke("s6", 5f);
        Invoke("s7", 6f);
        Invoke("s8", 7f);
        Invoke("s9", 8f);
        Invoke("s10", 11f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void s1()
    {
        sprite1.SetActive(true);
    }
    void s2()
    {
        sprite2.SetActive(true);
    }
    void s3()
    {
        sprite3.SetActive(true);
    }
    void s4()
    {
        sprite4.SetActive(true);
    }
    void s5()
    {
        sprite5.SetActive(true);
    }
    void s6()
    {
        sprite6.SetActive(true);
    }
    void s7()
    {
        sprite7.SetActive(true);
    }
    void s8()
    {
        sprite8.SetActive(true);
    }
    void s9()
    {
        sprite9.SetActive(true);
    }
    void s10()
    {
        sprite10.SetActive(true);
    }

}
