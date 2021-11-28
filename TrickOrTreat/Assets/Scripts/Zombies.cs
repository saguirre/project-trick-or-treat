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
            Instantiate(zombies, new Vector3(positionIndex * 0.2F, -0.07F, 0), Quaternion.identity);
        }
    }
}
