using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferMapBack : MonoBehaviour
{
    public GameObject targetObj;
    public GameObject toObj;
    public float sleepVelocity;
    public BoxCollider2D targetbound;

    private CameraManager theCamera;

    [SerializeField]
    float minX;
    float maxX;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            targetObj = collision.gameObject;
           // theCamera.SetBound(targetbound);
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player")&&Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(TeleportRoutine());
        }

    }
    IEnumerator TeleportRoutine()
    {
        yield return null;
        yield return new WaitForSeconds(0.5f);
        targetObj.transform.position = toObj.transform.position;
        

    }




    // Update is called once per frame
    void Update()
    {

    }
}
