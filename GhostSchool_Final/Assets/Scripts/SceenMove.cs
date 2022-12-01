using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceenMove : MonoBehaviour
{

    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //SceneManager.LoadScene("Lock_Button1", LoadSceneMode.Additive);
            Panel.SetActive(true);
        }
    }


}
