using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public string nScene;
    // Start is called before the first frame update
    public void newScene()
    {
        SceneManager.LoadScene(nScene);
    }

}
