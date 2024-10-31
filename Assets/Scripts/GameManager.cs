using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int enemies;
    public static int nurses;
    public Text enemyText;
    public Text nurseText;
    // Update is called once per frame
    void Update()
    {
        enemyText.text = enemies.ToString();
        nurseText.text = nurses.ToString();
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

}
