using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{



    // Update is called once per frame
    void Update()
    {

    }


    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void play2()
    {
        SceneManager.LoadScene(2);
    }
}
