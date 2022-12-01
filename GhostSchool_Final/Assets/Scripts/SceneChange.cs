using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject soundPanel;
    public GameObject startPanel;
    public GameObject hintPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TitleToMain()
    {
        GameObject camera = GameObject.Find("Tutorial_Camera");
        Destroy(camera);

        SceneManager.LoadScene("Map");

    }
    public void Title()
    {
        SceneManager.LoadScene("Title");
    }

    public void TitleToMap1()
    {
        SceneManager.LoadScene("Map1");
    }

    public void Cutscenes2()
    {
        SceneManager.LoadScene("CutScenes2");
    }

    public void Cutscenes3()
    {
        SceneManager.LoadScene("CutScenes3");
    }




    public void TitleToTutorial()
    {
        SceneManager.LoadScene("CutScenes");
    }

    public void Setting()
    {
        menuPanel.SetActive(true);
        soundPanel.SetActive(false);
    }

    public void sound()
    {
        soundPanel.SetActive(true);
        menuPanel.SetActive(false);
    }
    public void close()
    {
        soundPanel.SetActive(false);
        menuPanel.SetActive(false);
        startPanel.SetActive(false);
        hintPanel.SetActive(false);
    }

 

}
