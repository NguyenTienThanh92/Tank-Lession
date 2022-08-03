using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;


public class GameManager : MonoBehaviour
 {
    
    public EnemyController tankEnemy;
    public int scorePlayer;
    public Text levelTxt;

    private void Awake()
    {
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, AddScore);
    }
    void Update()
    {
        levelTxt.text = "Level : " + scorePlayer.ToString();
    }
    public void AddScore(object data)
    {
        scorePlayer += 50;
    }
}
public class GameController : SingletonMonoBehaviour<GameManager>
{

}
