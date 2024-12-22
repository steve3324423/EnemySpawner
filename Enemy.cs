using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 10f;
    private Vector3 _direction;

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,_direction,_speed * Time.deltaTime);
    }
}
