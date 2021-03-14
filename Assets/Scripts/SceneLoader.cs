using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void loadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void loadSceneByIndex(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
}
