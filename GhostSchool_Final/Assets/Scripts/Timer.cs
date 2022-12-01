using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float deltaTime = 0f;

    private SpriteRenderer startImage;
    public Sprite a;
    public Sprite b;
    public Sprite c;
    public Sprite d;
    public Sprite e;
    public Sprite f;
    public Sprite g;
    public Sprite h;

    private void Start()
    {
        startImage = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        deltaTime += Time.deltaTime;

        if (deltaTime >= 10.0f && deltaTime <20.0f)
        {
            startImage.sprite = a;
        }
        if (deltaTime >= 20.0f && deltaTime < 30.0f)
        {
            startImage.sprite = b;
        }
        if (deltaTime >=30.0f && deltaTime < 40.0f)
        {
            startImage.sprite = c;
        }
        if (deltaTime >= 40.0f && deltaTime < 50.0f)
        {
            startImage.sprite = d;
        }
        if (deltaTime >= 50.0f && deltaTime < 60.0f)
        {
            startImage.sprite = e;
        }
        if (deltaTime >= 60.0f && deltaTime < 70.0f)
        {
            startImage.sprite = f;
        }
        if (deltaTime >= 70.0f && deltaTime < 80.0f)
        {
            startImage.sprite = g;
        }
        if (deltaTime >= 80.0f && deltaTime < 90.0f)
        {
            startImage.sprite = h;
        }


    }
}
