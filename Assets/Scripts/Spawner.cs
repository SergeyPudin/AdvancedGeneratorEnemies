using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoins;
    [SerializeField] private float _deley = 2.0f;
    
    private Enemy _enemyPrefab;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            int random = Random.Range(0, _spawnPoins.Length);
            SpawnPoint spawnPoint = _spawnPoins[random];            
            var wait = new WaitForSeconds(_deley);

            GetEnemy(spawnPoint);

            Enemy enemy = Instantiate(_enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
            enemy.GetTarget(spawnPoint.Target);

            yield return wait;
        }
    }

    private void GetEnemy(SpawnPoint spawnPoint)
    {
        _enemyPrefab = spawnPoint.EnemyPrefab;
    }
}