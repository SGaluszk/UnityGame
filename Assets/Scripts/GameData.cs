using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void SaveScene()
    {
        int activeSceneID = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("LastFinishedLevelIndex", activeSceneID);
    }
    public void LoadScene()
    {
        int activeSceneID = PlayerPrefs.GetInt("LastFinishedLevelIndex");
        SceneManager.LoadScene(activeSceneID);
    }
}
