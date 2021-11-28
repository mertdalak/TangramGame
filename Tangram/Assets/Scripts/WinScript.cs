using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject pieces;
    public int seconds = 2;
    
    void Start()
    {
        pointsToWin = pieces.transform.childCount;
    }

    
    void Update()
    {
        if(currentPoints >= pointsToWin)
        {
            //WIN
            transform.GetChild(0).gameObject.SetActive(true);
            Wait(); 
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }

    void Wait()
    {
        for (float ft = 7f; ft >= 0; ft -= 0.1f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
