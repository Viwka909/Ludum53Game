using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideSceneChange : MonoBehaviour
{
    public string sceneName;
    void  OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneName);
    }
}
