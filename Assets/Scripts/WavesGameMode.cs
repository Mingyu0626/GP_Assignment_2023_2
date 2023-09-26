using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] Life playerLife;
    void Start()
    {
        
    }
    void Update()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 &&
            WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }

        if (playerLife.amount <= 0 || EnemiesManager.instance.enemies.Count >= 30)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
}