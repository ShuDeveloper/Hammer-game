using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [SerializeField] void StopGame()
    {
        Time.timeScale = 0;
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
    }
}
