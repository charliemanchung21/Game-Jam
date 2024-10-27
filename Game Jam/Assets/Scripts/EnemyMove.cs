using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform posA, posB;
    public float speed;
    private float direction = 0f;
    private bool flipped = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(posA.position, posB.position, Mathf.PingPong(Time.time * speed, 1.0f));
        direction = Mathf.PingPong(Time.time * speed, 1.0f);
        if (direction > 0.99 && !flipped)
        {
            Flip();
            flipped = true;
        }
        else if (direction < 0.01 && flipped)
        {
            Flip();
            flipped = false;
        }
        
        

    }

    
    private void Flip()
    { 
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
     
    }
}
