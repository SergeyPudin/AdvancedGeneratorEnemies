using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{    
    [SerializeField] private float _moveSpeed;
   
    private EnemyTarget _target;
    
    private void Update()
    {
        if (_target == null)
            return;

        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position ,Time.deltaTime * _moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyTarget>())
        {
            Destroy(gameObject);
        }
    }

    public void GetTarget(EnemyTarget target)
    {
        _target = target;
    }
}