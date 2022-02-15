using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    private GameData gameData;
    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

    void Awake()
    {
        gameData = GameObject.FindGameObjectWithTag("GameData").GetComponent<GameData>();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        gameData.SaveScene();

    }


    public void LoadGameMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit button was pressed!");
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadLastLevel()
    {
        gameData.LoadScene();
        Debug.Log("Last level loaded");
    }
}
