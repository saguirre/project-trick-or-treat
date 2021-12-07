using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpPlayerSound, stepsPlayerSound, hitPlayerSound, candySound, hitZombieSound;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        jumpPlayerSound = Resources.Load<AudioClip>("jumpPlayer");
        stepsPlayerSound = Resources.Load<AudioClip>("footStep");
        hitPlayerSound = Resources.Load<AudioClip>("playerHit");
        candySound = Resources.Load<AudioClip>("candy");
        hitZombieSound = Resources.Load<AudioClip>("zombieHit");

        audioSource = GetComponent<AudioSource> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)

    {
        switch (clip){
        case "jumpPlayer":
            audioSource.PlayOneShot(jumpPlayerSound);
            break;
            
        case "footStep":
            audioSource.PlayOneShot(stepsPlayerSound);
            break;

        case "playerHit":
            audioSource.PlayOneShot(hitPlayerSound);
            break;

        case "candy":
            audioSource.PlayOneShot(candySound);
            break;
        
        case "zombieHit":
            audioSource.PlayOneShot(hitZombieSound);
            break;
         }

    }
}
