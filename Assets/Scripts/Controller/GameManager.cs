using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;


public class GameManager : MonoBehaviour
 {
    
    public EnemyController tankEnemy;
    public int scorePlayer;
    public Text scoreTxt;
    public GameObject gate;

    private void Awake()
    {
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, AddScore);
    }
    void Update()
    {
        scoreTxt.text = "Score : " + scorePlayer.ToString();
    }
    public void AddScore(object data)
    {
        scorePlayer += 50;
        //Instantiate(tankEnemy, gate.transform.position, gate.transform.rotation);
    }
}
public class GameController : SingletonMonoBehaviour<GameManager>
{

}
// test
