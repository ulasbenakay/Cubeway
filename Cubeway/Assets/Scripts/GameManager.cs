using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float delayTime = 0.3f;
    public GameObject CompleteLevelUI;

   public void EndGame()
    {
        if (!gameHasEnded)
        {
            Invoke("Restart", delayTime);
            gameHasEnded = true;
        }
    }

    void Restart()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteGame()
    {
        CompleteLevelUI.SetActive(true);
    }
}
