using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRocksEvent : MonoBehaviour
{
    public List<GameObject> Children;
    public GameObject Rock;
    void Start()
    {
        StartCoroutine(Loop());
    }

    IEnumerator Loop()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.2f, 1));
            var positionIndex = Random.Range(0, Children.Count - 1);
            Instantiate(Rock.gameObject, Children[positionIndex].gameObject.transform.position, Quaternion.identity);
        }
    }
}
