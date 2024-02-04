using UnityEngine;

public class SpawnPoint : MonoBehaviour
{    
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private EnemyTarget _target;

    public Enemy EnemyPrefab => _enemyPrefab;
    public EnemyTarget Target => _target; 
}