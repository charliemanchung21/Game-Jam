using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCollectable : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public static int blueCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player 2")
        {
            Debug.Log("Player has collected a blue collectable");
            blueCount++;
            audioManager.PlaySFX(audioManager.collect);
            Destroy(gameObject);
        }
    }
}
