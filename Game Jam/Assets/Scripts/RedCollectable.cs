using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCollectable : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public static int redCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player has collected a red collectable");
            redCount++;
            audioManager.PlaySFX(audioManager.collect);
            Destroy(gameObject);
        }
    }
}
