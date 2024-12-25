using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Vector3[] _targets;

    private int _indexTarget = 0;

    public Vector3 GetTarget() => _targets[_indexTarget];

    public void OnAchievedTarget()
    {
        _indexTarget++;
        if(_indexTarget >= _targets.Length - 1)
            _indexTarget = 0;
    }
}
