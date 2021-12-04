using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollision : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate(0, 0, Random.Range(0f, 180f) * Time.deltaTime * Random.Range(1f, 5f));
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        //TODO: Que no haga dano al player
        gameObject.SetActive(false);
        Destroy(gameObject, 0.3f);
    }
}
