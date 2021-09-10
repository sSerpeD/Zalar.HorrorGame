using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoteMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuUI2;
    public AudioClip impact;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (GameIsPaused)
            {
                pauseMenuUI2.SetActive(false);
                Resume();
                audioSource.PlayOneShot(impact, 0.7F);
            }
            else
            {
                Pause();
                audioSource.PlayOneShot(impact, 0.7F);
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {

           if (GameIsPaused)
            {
                pauseMenuUI.SetActive(false);
                Resume2();
                audioSource.PlayOneShot(impact, 0.7F);
            }
            else
            {
            
                NextPage();
                audioSource.PlayOneShot(impact, 0.7F);
            } 
        }

        

    }

    void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        
    }

    void Resume2 ()
    {
        pauseMenuUI2.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        
    }

    void Pause ()
    {
        pauseMenuUI2.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
       
    }

    void NextPage()
    {
        pauseMenuUI.SetActive(false);
        pauseMenuUI2.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true; 
    }

   

    
}
