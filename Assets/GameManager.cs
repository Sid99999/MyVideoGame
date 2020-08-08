using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    bool gameEnd = false;

    public GameObject completeLevelUI;
    public GameObject collisionUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);

    }
    public void CollisionOccur()
    {
        collisionUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameEnd == false) {
            gameEnd = true;
        Debug.Log("GAMEOVER");
            Invoke("Restart",restartDelay);
    }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
