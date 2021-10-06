using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplitedMenu : MonoBehaviour

{
    public static bool GameIsPause = false;
    public GameObject finishCanvas;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        {
            if (other.tag =="PORTAL") {
                finishCanvas.SetActive(true);
                if (GameIsPause)
                {
                    Resume();
                } 
                else
                {
                    Pause();
                }
                void Resume ()
                {
                    finishCanvas.SetActive(false);
                    Time.timeScale = 1f;
                    GameIsPause = false;
                }
                void Pause ()
                {
                    finishCanvas.SetActive(true);
                    Time.timeScale = 0f;
                    GameIsPause = true;
                }
            }
        }
    }
}
