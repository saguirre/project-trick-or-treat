using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;

    void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead)
        {
            // Game over
            SceneManager.LoadScene("PlayerScene");
        }
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Player heart damaged");

        if (!dead)
        {
            life -= damage;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }
            SoundManagerScript.PlaySound("playerHit");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player collision");
        if (collision.gameObject.CompareTag("Rock") || collision.gameObject.CompareTag("Skull") || collision.gameObject.CompareTag("Zombie") )
        {
            TakeDamage(1);
        }
    }
}
