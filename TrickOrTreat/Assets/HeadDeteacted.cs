using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDeteacted : MonoBehaviour
{
    private Vector3 movement;
    GameObject Enemy;
    bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = gameObject.transform.parent.gameObject;
    }

    void Update()
    {
        if(dead){
            movement = new Vector3(0f, -2,0f);
            Enemy.transform.position = Enemy.transform.position + movement * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Collider2D>().enabled = false;
        Enemy.GetComponent<SpriteRenderer>().flipY = true;
        Enemy.GetComponent<Collider2D>().enabled = false;
        dead = true;
    }
}
