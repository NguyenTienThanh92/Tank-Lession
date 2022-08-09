using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;

public class PlayerLv2Controller : PlayerLv1Controller
{
    //public Text levelTxt;
    //public Text hpTxt;
    //public Slider slider_hp;
    public Transform gun2;
    public Transform transhoot2;
    public BulletController bullet2;

    private void Awake()
    {
        slider_hp.maxValue = hp;
    }
    private void Start()
    {
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, LevelUp);
    }
    void Update()
    {
        slider_hp.value = hp;
        if (hp <= 0 )
        {
            //Destroy(this.gameObject);
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);

        Move(direction);

        var position = Input.mousePosition;
        Vector3 gunDirectionmoba = new Vector3(
            position.x - Screen.width / 2,
            position.y - Screen.height / 2);

        RotateGun(gunDirectionmoba);
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        {
            hpTxt.text = "HP : " + hp.ToString();
        }
    }
    private void LevelUp(object data)
    {
        float levelEnemy = (float)data;
        level += levelEnemy;
        levelTxt.text = "Level : " + level.ToString();
        if (level >= 10)
        {
            Destroy(this.gameObject);
            //Instantiate()
        }
    }
    
    
   
}
public class Playerlv2 : SingletonMonoBehaviour<PlayerLv2Controller>
{

}
