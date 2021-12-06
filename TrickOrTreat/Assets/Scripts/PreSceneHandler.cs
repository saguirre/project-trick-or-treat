using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreSceneHandler : MonoBehaviour
{
    public int waitSeconds;
    public string nextScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            StartCoroutine(ChangeScene());

        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(waitSeconds);
        SceneManager.LoadScene(nextScene);
    }

}
