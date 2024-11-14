using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int enemies;
    public static int nurses;
    public Text enemyText;
    public Text nurseText;
    public GameObject canvasObject;
    public Text winOrLoseText;
    // Update is called once per frame


    void Update()
    {
        enemyText.text = enemies.ToString();
        nurseText.text = nurses.ToString();

        

        if (nurses >= 10 || enemies >= 50)
        {
            canvasObject.SetActive(true);

            if (nurses >= 10)
                winOrLoseText.text = "You've reached the treshold for the nurses you're allowed to hit 'Accidentally'";
            if (enemies >= 50)
                winOrLoseText.text = "Good, the world is in good hands, no more cops";

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            enemies++;
        }
        if (collision.collider.gameObject.tag == "Nurse")
        {
            nurses++;
        }
    }


    public void gameOver()
    {
        enemies = 0;
        nurses = 0;
        SceneManager.LoadScene(0);

    }
}
