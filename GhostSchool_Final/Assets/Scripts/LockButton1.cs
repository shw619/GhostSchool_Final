using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockButton1 : MonoBehaviour

{

    public GameObject Panel;
    public GameObject Panel2;
    public GameObject lockbutton;


    public Image LockImage;
    public Sprite OpenSprite;
    public Button Lock_button1;
    public Button Lock_button2;
    public Button Lock_button3;
    public Button Lock_button4;
    public Button Lock_button5;
    public Button Lock_button6;
    public Button Lock_button7;
    public Button Lock_button8;
    public int password = 4;
    private int result = 0;

    private int num = 0;

    private bool keyInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(num == 4)
        {
            if(password == result)
            {
                ChangeImage();
                BookCount.bookCount = 1;
                SceneManager.LoadScene("Map");
            }
        }

            if (Input.GetKeyDown(KeyCode.Space))
        {
            lockbutton.SetActive(false);
        }

    }

    public void ChangeImage()
    {
        LockImage.sprite = OpenSprite;
    }
    public void OnclickButton1()
    { 
        Lock_button1.interactable = false;
        result += 1;
        num += 1;
        Debug.Log(result);
    }
     public void OnclickButton2()
    {
        Lock_button2.interactable = false;
        result += 1;
        num += 1;
        Debug.Log(result);
    }
     public void OnclickButton3()
    {
       Lock_button3.interactable = false;
       result += 1;
       num += 1;
       Debug.Log(result);
    }
     public void OnclickButton4()
    {
        Lock_button4.interactable = false;
        result += 1;
        num += 1;
        Debug.Log(result);
    }
     public void OnclickButton5()
    {
       Lock_button5.interactable = false;
       result -= 1;
       num += 1;
       Debug.Log(result);
    }
     public void OnclickButton6()
    {
        Lock_button6.interactable = false;
        result -= 1;
        num += 1;
        Debug.Log(result);
    }
     public void OnclickButton7()
    {
        Lock_button7.interactable = false;
        result -= 1;
        num += 1;
        Debug.Log(result);
    }
     public void OnclickButton8()
    {
        Lock_button8.interactable = false;
        result -= 1;
        num += 1;
        Debug.Log(result);  
    }
}
