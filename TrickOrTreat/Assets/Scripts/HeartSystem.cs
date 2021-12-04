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
    private Animator animator;

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
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player collision");
        if (collision.gameObject.CompareTag("Rock") || collision.gameObject.CompareTag("Skull"))
        {
            TakeDamage(1);
        }
        if(collision.gameObject.CompareTag("Zombie"))
        {
            TakeDamage(1);
            Destroy(collision.gameObject);
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
            animator = gameObject.GetComponent<Animator>();
            animator.Play("Damage", 0, 0.0f);
            
            StartCoroutine(DamageFlicker());
        }
    }

    IEnumerator DamageFlicker()
    {
        this.GetComponent<BoxCollider2D>().enabled = false; 
        canTakeDamage = false;

        for (int i = 0; i < flickerAmnt; i++)
        {
            sprite.color = new Color(1f, 1f, 1f, .5f);
            yield return new WaitForSeconds(flickerDuration);
            sprite.color = Color.white;
            yield return new WaitForSeconds(flickerDuration);
        }
        canTakeDamage = true;
        this.GetComponent<BoxCollider2D>().enabled = true; 
    }
}
