using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player 2")
        {
            Debug.Log("Player has died");
            audioManager.PlaySFX(audioManager.death);
            RedCollectable.redCount = 0;
            BlueCollectable.blueCount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
