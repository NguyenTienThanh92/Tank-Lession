using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public EnemyController tankEnemy;
    public int scorePlayer;
    public Text levelTxt;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    void Update()
    {
        levelTxt.text = "Level : " + scorePlayer.ToString();
    }
    public void AddScore()
    {
        scorePlayer += 50;
    }
}
