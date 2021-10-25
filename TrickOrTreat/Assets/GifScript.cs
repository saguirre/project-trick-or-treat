using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GifScript : MonoBehaviour
{
    public SpriteRenderer imageZombie;
    public Sprite[] animateImages;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        imageZombie.sprite = animateImages[(int)(Time.time*10)%animateImages.Length];
    }
}
