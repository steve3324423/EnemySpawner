using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyFactory _factory;
    [SerializeField] private Vector3[] _directions;

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
            Enemy enemy = _factory.Create(transform.position);
            enemy.SetDirection(_directions);
            yield return _waitSeconds;
        }
    }
}
