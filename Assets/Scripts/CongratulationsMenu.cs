using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratulationsMenu : MonoBehaviour
{
    public static bool isLevelPassed = false;
    public GameObject congratulationsMenuUI;
    private GameData gameData;


    private void Awake()
    {
        gameData = GameObject.FindGameObjectWithTag("GameData").GetComponent<GameData>();
        gameData.SaveScene();
        isLevelPassed = false;
        congratulationsMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            Debug.Log("Test");
            LevelPassed();
        }
    }


    void LevelPassed()
    {
        if (SceneManager.GetActiveScene().buildIndex < Application.levelCount - 1) {
            congratulationsMenuUI.SetActive(true);
            Time.timeScale = 0f;
            isLevelPassed = true;
        }

        else
        {
            SceneManager.LoadScene("GameFinished");
        }
            
    }

}
