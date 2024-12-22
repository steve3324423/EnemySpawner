using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public Enemy Create(Vector3 positionSpawn)
    {
        return Instantiate(_enemy,positionSpawn,Quaternion.identity);
    }
}
