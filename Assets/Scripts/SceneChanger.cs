using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeSceneWithDelay(string sceneName, float delay)
    {
        StartCoroutine(ChangeScene(sceneName, delay));
    }

    private IEnumerator ChangeScene(string sceneName, float delay)
    {
        
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("ex");
    }
}
