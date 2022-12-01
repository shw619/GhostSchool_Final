using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_wasd : MonoBehaviour
{
    int[] wasd_order = new int[7];
    int[] check = new int[7];
    public GameObject[] direction;
    int count = 0;

    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject open;
    public GameObject close;


    void Start()
    {
        setWasdOrder();
        StartCoroutine(onOffTime());
        //inputKey();
    }
    void Awake()
    {
        //inputKey();
    }
    void Update()
    {
     switch(Input.inputString)
        {
            case "w":
                keydown_w();
                count++;
                break;

            case "a":
                keydown_a();
                count++;
                break;

            case "s":
                keydown_s();
                count++;
                break;

            case "d":
                keydown_d();
                count++;
                break;

        }

        if(count == 7 && Input.GetKeyDown(KeyCode.Space))
        {
            close.SetActive(false);
            open.SetActive(true);
            
        }
    }


    void setWasdOrder ()
    {
        for(int i = 0; i<7;i++)
        {
            wasd_order[i]= Random.Range(0, 4);
            Debug.Log("a");
        }
    }



    void onOff(int element)
    {
        direction[wasd_order[element]].SetActive(true);


        //StartCoroutine(onOffTime(element));

        Debug.Log("b");
    }


    void onOffWasd()
    {
        //for(int i = 0; i<7; i++)
        //{
        //    onOff(i);
        //    StartCoroutine(onOffTime(i));
        //}
    }

    IEnumerator onOffTime()
    {
        Debug.Log("d");

        for (int i = 0; i < 7; i++)
        {
            onOff(i);
            check[i]++;
            yield return new WaitForSeconds(0.2f);
            direction[wasd_order[i]].SetActive(false);
            yield return new WaitForSeconds(0.2f);
        }
  
    }



    //void inputKey()
    //{
      
    //  if (Input.GetKeyDown(KeyCode.W))
    //            {
    //            keydown_w();
               
    //            }
    //            else if (Input.GetKeyDown(KeyCode.S))
    //    {
    //        keydown_a();

    //    }
    //    else if (Input.GetKeyDown(KeyCode.A))
    //            {
    //        keydown_s();

    //    }
    //    else
    //        keydown_d();


    //}

    void off()
    {
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
    }

    private void keydown_w()
    {
        a.SetActive(true);
        Invoke("off", 0.3f);
    }

    private void keydown_a()
    {
       b.SetActive(true);
        Invoke("off", 0.3f);
    }

    private void keydown_s()
    {
       c.SetActive(true);
        Invoke("off", 0.3f);
    }

    private void keydown_d()
    {
       d.SetActive(true);
        Invoke("off", 0.3f);
    }

}
