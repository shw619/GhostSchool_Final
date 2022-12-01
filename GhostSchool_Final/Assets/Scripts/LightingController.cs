using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightingController : MonoBehaviour
{
    float deltaTime = 0f;

    private SpriteRenderer startImage;
    public Sprite a;
    public Sprite b;
    public Sprite c;

    private void Start()
    {
        startImage = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        deltaTime += Time.deltaTime;

        if (deltaTime >=  10.0f && deltaTime < 200.0f)
        {
            startImage.sprite = a;
        }
        if (deltaTime >=  20.0f && deltaTime < 70.0f)
        {
            startImage.sprite = b;
        }
        if (deltaTime >= 70.0f && deltaTime < 90.0f)
        {
            startImage.sprite = c;
        }


    }
}
