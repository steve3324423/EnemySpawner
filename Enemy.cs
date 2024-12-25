using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Target _target;
    private float _speed = 10f;

    public void SetTarget(Target target)
    {
        _target = target;
    }

    private void Update()
    {
        SetTargetPosition();
    }

    private void SetTargetPosition()
    {
        Vector3 offset = transform.position - _target.GetTarget();
        float minDistance = .1f;

        if (offset.sqrMagnitude <= minDistance * minDistance)
            _target.OnAchievedTarget();
        else
            StepToTarget();
    }

    private void StepToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position,_target.GetTarget(),_speed * Time.deltaTime);
    }
}
