using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) && Input.GetKey(KeyCode.Alpha2) && Input.GetKey(KeyCode.Alpha3) && Input.GetKey(KeyCode.Alpha0))
        {
            Debug.Log("Reset!");
            Singleton.Instance.inv = new List<Key.KeyType>();
            SceneManager.LoadScene("Intro");
        }
    }
}
