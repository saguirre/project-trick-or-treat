using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public SpriteRenderer sprite;
    private int life;
    private bool dead;
    public static bool canTakeDamage;
    public int flickerAmnt;
    public float flickerDuration;

    void Start()
    {
        canTakeDamage = true;
        life = hearts.Length;
    }

    void Update()
    {
        if (dead)
        {
            SceneManager.LoadScene("GameOver");
            //SceneManager.LoadScene("PlayerScene");
        }
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Player heart damaged");

        if (!dead && canTakeDamage)
        {
            life -= damage;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }
            SoundManagerScript.PlaySound("playerHit");
            StartCoroutine(DamageFlicker());
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

    IEnumerator DamageFlicker()
    {
        canTakeDamage = false;
        for (int i = 0; i < flickerAmnt; i++)
        {
            sprite.color = new Color(1f, 1f, 1f,.5f);
            yield return new WaitForSeconds(flickerDuration);
            sprite.color = Color.white;
            yield return new WaitForSeconds(flickerDuration);
        }
         canTakeDamage = true;
    }
}
