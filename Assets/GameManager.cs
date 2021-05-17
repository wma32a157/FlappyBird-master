using UnityEngine;
using UnityEngine.UI;

/// <summary>
///  기둥 통과할때마다 점수 100씩 올리자
///  새가 뒤지면 게임 종료 UI 표시 하자.
/// </summary>
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text scoreUI;

    static public GameManager instace;


    private void Awake()
    {
        instace = this;
        gameOverUI.SetActive(false);

    }

    internal void ShowGameOver(bool active)
    {
        gameOverUI.SetActive(active);
    }
}

