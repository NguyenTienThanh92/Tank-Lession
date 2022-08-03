using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class CameraController : MonoBehaviour
{
    void Update()
    {
        var Tank = Player.Instance;
        Transform tank = Tank.transform;
        Vector3 newPos = new Vector3(tank.position.x, tank.position.y, -10f);
        transform.position = Vector3.Lerp(transform.position, newPos, 0.3f);
    }
}
