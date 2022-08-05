using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class WaveController : MonoBehaviour
{
    public List<EnemyController> _tankEnemy = new List<EnemyController>();
    public EnemyController enemySample;
    [SerializeField] private Transform[] _gate;
    private int _enemyInWave = 0;

    public void Start()
    {
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, CalculateWave);
        _tankEnemy.Add(enemySample);
        CreatWave();
    }
    public void CreatWave()
    {
        for (int i = 0; i < _tankEnemy.Count; i++)
        {
            var enemy = _tankEnemy[i];
            var gate = Random.Range(0, _gate.Length);
            Instantiate(enemy, _gate[gate].position, _gate[gate].rotation);
        }

    }
    void Update()
    {
        
    }
    private void CalculateWave (object data)
    {
        _enemyInWave += 1;
        if (_enemyInWave == _tankEnemy.Count)
        {
            if (_tankEnemy.Count <= 10)
            {
                _tankEnemy.Add(enemySample);
                CreatWave();
            }
            else
            {
                CreatWave();
                _enemyInWave = 0;
            }
        }
    }
}
