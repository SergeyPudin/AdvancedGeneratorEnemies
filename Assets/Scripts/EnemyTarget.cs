using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyTarget : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private TargetPoint[] _targetPoint;

    private int _currentTargetPointIndex = 0;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (transform.position == _targetPoint[_currentTargetPointIndex].transform.position)
        {
            _currentTargetPointIndex = (_currentTargetPointIndex + 1) % _targetPoint.Length;
            _spriteRenderer.flipX = !_spriteRenderer.flipX;
        }

        transform.position = Vector3.MoveTowards(transform.position, _targetPoint[_currentTargetPointIndex].transform.position, _moveSpeed * Time.deltaTime);
    }
}