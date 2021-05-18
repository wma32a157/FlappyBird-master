using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
///  기둥 통과할때마다 점수 100씩 올리자
///  새가 뒤지면 게임 종료 UI 표시 하자.
/// </summary>
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text scoreUI;
    public float scrollSpeedXMuItiply = 1;

    static public GameManager instace;
    private int score;

    private void Awake()
    {
        instace = this;
        gameOverUI.SetActive(false);

    }

    bool isGameOver;// = false;//?
    internal float scrollSpeedXMuItiPly;

    internal void SetGameOver()
    {
        isGameOver = true;
        ShowGameOver(true);

    }
    internal void ShowGameOver(bool active)
    {
        gameOverUI.SetActive(active);
    }

    internal void AddScore()
    {
        score += 100;
        scoreUI.text = "Score : " + score;
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                //게임 재시작.
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        
       
    }
}

