using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
    public void Load(string scene)
    {
        Debug.Log("loaded: " + scene);
        SceneManager.LoadScene(scene);
    }
}
