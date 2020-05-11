using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    [Header("Audio mixer in the scene is added here")]
    [Tooltip("This enable the UI slider to edit the sound that comes threw the audio mixer")]
    public AudioMixer audioMixer;
    

    

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    
    public void SetVolume(float volume)
    {
        Debug.Log("Volumechange");
        audioMixer.SetFloat("volume", volume);
        
    }
   
}
