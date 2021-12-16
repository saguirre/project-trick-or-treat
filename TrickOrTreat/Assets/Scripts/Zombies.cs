using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public GameObject zombies;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Wait()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 4));
            var positionIndex = Random.Range(-8, 8);
            var zombo = Instantiate(zombies, new Vector3(positionIndex * 0.2F, -0.07F, 0), Quaternion.identity);
            zombo.GetComponent<BoxCollider2D>().enabled = false;
            yield return new WaitForSeconds(0.5f);
            zombo.GetComponent<BoxCollider2D>().enabled = true;

        }
    }
}
