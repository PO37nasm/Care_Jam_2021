using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField]
    private int nextScene;
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void LoadLevel(int levelID)
    {
        SceneManager.LoadScene(levelID);
    }
}
