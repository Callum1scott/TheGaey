using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        PlayerPrefs.SetInt("checkpointReached", 0);
        SceneManager.LoadScene("SampleScene");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Setting SCreen");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credit scene");
    }
}
