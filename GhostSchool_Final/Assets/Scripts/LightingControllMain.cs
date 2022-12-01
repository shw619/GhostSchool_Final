using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightingControllMain : MonoBehaviour
{
    float deltaTime = 0f;

    private SpriteRenderer startImage;
    public Sprite a;
    public Sprite b;
    public Sprite c;

    [SerializeField]
    float one = 300.0f;
    [SerializeField]
    float two = 500.0f;
    [SerializeField]
    float three = 700.0f;
    [SerializeField]
    float four = 900.0f;

    private void Start()
    {
        startImage = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        deltaTime += Time.deltaTime;

        if (deltaTime >= one && deltaTime < two)
        {
            startImage.sprite = a;
        }
        if (deltaTime >= two && deltaTime < three)
        {
            startImage.sprite = b;
        }
        if (deltaTime >= three && deltaTime < four)
        {
            startImage.sprite = c;
        }


    }
}
