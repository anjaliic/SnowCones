using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
    public void Load(string scene)
    {
        //loads scene that the string inputs by name
        SceneManager.LoadScene(scene);
    }

    public void dayCount()
    {
        //increases the day by 1
        GameManager.day = GameManager.day + 1;
    }
}
