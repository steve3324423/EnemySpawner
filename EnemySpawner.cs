using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform[] _directions;
    [SerializeField] private EnemyFactory _factory;

    private float _timeForCoroutine = 2f;
    private WaitForSeconds _waitSeconds;

    private void Awake()
    {
        _waitSeconds = new WaitForSeconds(_timeForCoroutine);
    }

    private void Start()
    {
        StartCoroutine(SpawnRandomPosition());
    }

    private IEnumerator SpawnRandomPosition()
    {
        bool isCoroutineRun = true;

        while(isCoroutineRun)
        {
            Enemy enemy = _factory.Create(_spawnPoints[Random.Range(0,_spawnPoints.Length)].position);
            enemy.SetDirection(_directions[Random.Range(0, _directions.Length)].position);

            yield return _waitSeconds;
        }
    }
}
