using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private TMP_Text ScoreText;

    private int score;
    public float timer;
    private float scrollSpeed;
    public float initialScrollSpeed = 8f;

    public static GameManager Instance { get; private set; }


    public void RestartScene()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Time.timeScale = 1f;
    }

}
