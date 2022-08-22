using UnityEngine;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;

public class PlayerLv1Controller : TankController 
{
    public Text levelTxt;
    public Text hpTxt;
    public Slider slider_hp;
    public GameObject tankLv2;
    public GameObject gun1;
    public GameObject gun2;
    public Transform transhoot1;
    public Transform transhoot2;
    private bool _itemGunUp = false;

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
        gun1.SetActive(_itemGunUp);
        gun2.SetActive(_itemGunUp);

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
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (collision.gameObject.tag == "itemGunUp")
            {
                _itemGunUp = true;
                Destroy(collision.gameObject);
            }
        
        
            base.OnTriggerEnter2D(collision);
        
    }
    protected override void Shoot()
    {
        if (_itemGunUp)
        {
            CreatBullet(transhoot1);
            CreatBullet(transhoot2);
        }
        base.Shoot();
    }
}
public class Playerlv1 : SingletonMonoBehaviour<PlayerLv1Controller>
{

}
