using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDeteacted : MonoBehaviour
{
    GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Collider2D>().enable = false;
        Enemy.GetComopnent<SpriteRender>().flipY = true;
        Enemy.GetComopnent<Collider2D>().enable = false;
        Vector3 movemoent = new Vector3(Random.Range(40,70), Random.Range(-40,40), 0f);
        Enemy.transform.position += movemoent * Time.deltaTime;
    }
}
