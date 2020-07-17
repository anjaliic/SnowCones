using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //keeps track of current day
    public static int day = 1;
    //makes day number visible in inspector
    public int currentDay;

    void Awake()
    {
        //gamemanager doesnt get destroyed when scenes change
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        //sets "day" to the "currentDay" visible in inspector
        currentDay = day;
    }

}
