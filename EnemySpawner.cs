using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyFactory _factory;
    [SerializeField] private Target _target;

    private float _timeForCoroutine = 2f;
    private WaitForSeconds _waitSeconds;

    private void Awake()
    {
        _waitSeconds = new WaitForSeconds(_timeForCoroutine);
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        bool isCoroutineRun = true;

        while(isCoroutineRun)
        {
            Enemy enemy = _factory.Create(transform.position);
            enemy.SetTarget(_target);

            yield return _waitSeconds;
        }
    }
}
