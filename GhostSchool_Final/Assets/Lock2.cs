using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock2 : MonoBehaviour
{
    [SerializeField]
    GameObject open;
    
    [SerializeField]
    GameObject unOpen;

    [SerializeField]
    Sprite pushedButton;

    [SerializeField]
    Sprite defaultButton;

    bool isOpen = false;

    [SerializeField]
    GameObject[] buttons = new GameObject[8];
    bool[] isButtonPush = new bool[8];

    private void Awake()
    {
        for(int i = 0; i<8; i++)
        {
            isButtonPush[i] = false;
        }

        GameObject.Find("Player").GetComponent<PlayerController>().FixMove();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            check();
        }
    }

    void check()
    {
        if(isButtonPush[0] == true 
            && isButtonPush[1] == true
            && isButtonPush[2] == true
            && isButtonPush[3] == true)
        {
            isOpen = true;
        }

        if(isOpen)
        {
            open.SetActive(true);
            unOpen.SetActive(false);

            GameObject.Find("Player").GetComponent<PlayerController>().CommonMovement();
        }
    }
    public void debugg()
    {
        Debug.Log("gg");
    }
    public void buttonClick(int value)
    {

        Debug.Log("Click");

        if (isButtonPush[value])
        {
            buttons[value].GetComponent<SpriteRenderer>().sprite = pushedButton;
            isButtonPush[value] = true;
        }
        else
        {
            buttons[value].GetComponent<SpriteRenderer>().sprite = defaultButton;
            isButtonPush[value] = false;
        }
    }


}
