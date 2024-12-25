using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Vector3[] _targets;

    private Enemy _enemy;
    private int _indexTarget = 0;

    public Vector3 GetTarget() => _targets[_indexTarget];

    public void SetEnemy(Enemy enemy)
    {
        _enemy = enemy;
        _enemy.AchievedTarget += OnAchievedTarget;
    }

    private void OnDisable()
    {
        _enemy.AchievedTarget -= OnAchievedTarget;
    }

    private void OnAchievedTarget()
    {
        _indexTarget++;
    }
}
