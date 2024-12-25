using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3[] _directions;
    private int _indexTarget = 0;
    private float _speed = 10f;

    public void SetDirection(Vector3[] directions)
    {
        _directions = directions;
    }

    private void Update()
    {
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        if (transform.position == _directions[_indexTarget])
            _indexTarget++;

        transform.position = Vector3.MoveTowards(transform.position, _directions[_indexTarget],_speed * Time.deltaTime);
    }
}
