using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnkle : MonoBehaviour
{
    public AudioClip ankle;
    AudioSource audioSource;

    Vector3 pos; //������ġ

    float delta = 17.0f; // ��(��)�� �̵������� (x)�ִ밪

    float speed = 2.5f; // �̵��ӵ�

    void Start()
    {

        pos = transform.position;


    }
    void Awake()
    {

    }


    void Update()
    {

        Vector3 v = pos;

        v.x += delta * Mathf.Sin(Time.time * speed);

        transform.position = v;

    }


}
