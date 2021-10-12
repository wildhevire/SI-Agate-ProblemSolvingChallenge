using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject panel;
    
    void OnEnable()
    {
        ScoreManager.OnHitEnemy += OnGameOver;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackToMenu();   
        }
    }
    void OnDisable()
    {
        ScoreManager.OnHitEnemy -= OnGameOver;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    void OnGameOver()
    {
        panel.SetActive(true);
    }

    public void Restart()
    {
        var activeScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeScene);
    }
}
