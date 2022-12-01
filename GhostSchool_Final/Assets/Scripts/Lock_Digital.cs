using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lock_Digital : MonoBehaviour
{
    public Image LockImage;
    public GameObject lockimage;
    public Sprite OpenSprite;

    public Button Lock_button1;
    public Button Lock_button2;
    public Button Lock_button3;
    public Button Lock_button4;
    public Button Lock_button5;
    public Button Lock_button6;

    public int password = 4;
    private int result = 0;

    private int num = 0;

    bool isClear = false;
    int[] passWord = new int[4];
   
    [SerializeField]
    AudioClip[] clips;

    private bool keyInput;
    // Start is called before the first frame update
    void Awake()
    {
        clips = new AudioClip[6]; 
    }

    // Update is called once per frame
    void Update()
    {
        input();
    }

    void check()
    {

    }

    void makePassWord()
    {
        for(int i = 0; i < 4; i++)
        {
            passWord[i] = Random.Range(1, 6);
        }
        
        for(int i = 0; i< 4; i++)
        {
            playSound(i);
        }

    }   
    void playSound(int value)
    {
        GetComponent<AudioSource>().clip = clips[value];
        Invoke("playAudio", 0.5f);
    }

    void playAudio()
    {
        GetComponent<AudioSource>().Play();
    }

    void input()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("교과서 획득");
            ChangeImage();
            SceneManager.LoadScene("Map");
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
        result -= 1;
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
        result += 1;
        num += 1;
        Debug.Log(result);
    }
    
}
