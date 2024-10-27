using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy : MonoBehaviour
{
    public GameObject enemy;
    public bool isMovingRight = true;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Flip();
        }
    }
    
    private void Flip()
    {
        Vector3 theScale = enemy.transform.localScale;
        theScale.x *= -1;
        enemy.transform.localScale = theScale;
    }

    private void Update()
    {
        if (isMovingRight)
        {
            enemy.transform.Translate(Vector2.right * 2 * Time.deltaTime);
        }
        else
        {
            enemy.transform.Translate(Vector2.left * 2 * Time.deltaTime);
        }
    }
}
