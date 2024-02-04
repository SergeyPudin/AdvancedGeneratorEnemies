using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationSwitcher : MonoBehaviour
{
    private const int UpDirection = 1;
    private const int DownDirection = 2;
   
    private Animator _animator;
    private Vector3 _previusPosition;
    private int _direction = Animator.StringToHash("DirectionIndex");

    private void Start()
    {
        _previusPosition = transform.position;
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 currentVelocity = ((transform.position - _previusPosition) / Time.deltaTime).normalized;
                
        float verticalMovement = currentVelocity.y;

        _previusPosition = transform.position;

        if (verticalMovement > 0)
        {           
            _animator.SetInteger(_direction, UpDirection);
        }
        else
        {
            _animator.SetInteger(_direction, DownDirection);
        }        
    }
}