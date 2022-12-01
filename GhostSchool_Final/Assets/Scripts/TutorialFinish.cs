using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TutorialFinish : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("CutScenes");
        }
    }

}
