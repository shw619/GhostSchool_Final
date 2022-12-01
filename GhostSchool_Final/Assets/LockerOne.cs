using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerOne : MonoBehaviour
{
    [SerializeField]
    GameObject Dial;            // ȸ����ų ���̾�

    [SerializeField]
    GameObject UnOpenedLock;    // ������ ���� �ڹ��� ���
    
    [SerializeField]
    GameObject OpenedLock;      // ���� �ڹ��� ���

    [SerializeField]
    GameObject OpenLocker;

    GameObject Player;

    AudioSource audio;

    [SerializeField]
    AudioClip openClip;

    float rotateSpeed = 30f;
    bool isOpen; // �ڹ��谡 ���ȴ°�
    bool canMoveDial = true;

    float randKeyValue;
    float keyRange = 0.05f;

    private void Awake()
    {
        randKeyValue = Random.Range(-1f, 1f);
        Debug.Log(randKeyValue);

        audio = GetComponent<AudioSource>();

        // �÷��̾��� �������� ���´�.
        Player = GameObject.Find("Player");

        Player.GetComponent<PlayerController>().FixMove();

    }

    private void Update()
    {
        rotateDial();

        check();

        open();
    }

    void rotateDial()
    {
        if (!canMoveDial) return;

        if (Input.GetKey(KeyCode.A))
        {
            Dial.transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
            audio.Play();
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Dial.transform.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);
            audio.Play();
        }
    }

    void check()
    {

    }

    void open()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            float temp = Dial.transform.rotation.z;
            if(temp >= randKeyValue - keyRange
                && temp <= randKeyValue + keyRange)
            {
                openLocker();
            }
        }
    }

    void openLocker()
    {
        OpenedLock.SetActive(true);
        OpenLocker.SetActive(true);
        UnOpenedLock.SetActive(false);
        canMoveDial = false;

        Invoke("closeLocker", 2.0f);
    }

    void closeLocker()
    {
        audio.clip = openClip;
        audio.volume = 1.0f;
        audio.Play();

        Player.GetComponent<PlayerController>().CommonMovement();

        BookCount bookCount = GameObject.Find("BookText").GetComponent<BookCount>();
        bookCount.addCount();


        Destroy(this.gameObject);
    }

}
