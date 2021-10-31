using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullMovementReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "SkullMovementEndPosition")
        {
            transform.SetPositionAndRotation(new Vector2(2f, Random.Range(-0.175f, 0.378f)), Quaternion.identity);
        }
        else if (collision.collider.tag == "Wall")
        {
            Physics2D.IgnoreCollision(collision.otherCollider, collision.collider);
        }
    }
}
