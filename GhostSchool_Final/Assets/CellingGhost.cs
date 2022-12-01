using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellingGhost : MonoBehaviour
{
    [SerializeField]
    GameObject ghost;

    public bool isPlayerCome = false;
    public AudioClip celling;
    AudioSource audioSource;

    [SerializeField]
    float speed = 0.5f;

    bool isplay = false;

    private void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(isPlayerCome)
        {
            ghost.transform.Translate(0, -speed * Time.deltaTime,0);

            if (!isplay)
            {
                audioSource.clip = celling;
                audioSource.Play();
                isplay = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Player"))
        {
            isPlayerCome = true;
            Debug.Log("t");
            Invoke("setFalsePalyerCome", 0.7f);
        }
    }

    void setFalsePalyerCome()
    {
        isPlayerCome = false;
    }
}
