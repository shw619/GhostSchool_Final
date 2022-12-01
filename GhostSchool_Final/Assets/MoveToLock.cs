using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLock : MonoBehaviour
{
    [SerializeField]
    GameObject hint;

    [SerializeField]
    GameObject open;

    [SerializeField]
    string sceneName;

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKey(KeyCode.Space))
        {
            open.SetActive(true);
            hint.SetActive(false);
            SceneManager.LoadScene(sceneName);
        }
    }
}
