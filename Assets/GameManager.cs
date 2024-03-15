using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverCanvas;
    
    private void Start()
    {
        Time.timeScale = 1;
    }
    
    public void Gameover()
    {
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
} 
