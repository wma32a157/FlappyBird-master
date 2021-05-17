using UnityEngine;
using UnityEngine.UI;

/// <summary>
///  ��� ����Ҷ����� ���� 100�� �ø���
///  ���� ������ ���� ���� UI ǥ�� ����.
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

