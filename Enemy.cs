using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Target _target;
    private float _speed = 10f;

    public event Action AchievedTarget;

    public void SetTarget(Target target)
    {
        _target = target;
        _target.SetEnemy(this);
    }

    private void Update()
    {
        if (transform.position == _target.GetTarget())
            AchievedTarget?.Invoke();
        else
            StepToTarget();
    }

    private void StepToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position,_target.GetTarget(),_speed * Time.deltaTime);
    }
}
