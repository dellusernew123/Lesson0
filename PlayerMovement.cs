using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private KeyCode _jumpKey = KeyCode.Space;
    [SerializeField] private KeyCode _forwardKey = KeyCode.W;
    [SerializeField] private KeyCode _backKey = KeyCode.S;
    [SerializeField] private KeyCode _leftKey = KeyCode.A;
    [SerializeField] private KeyCode _rightKey = KeyCode.D;


    private bool _isJumping = false;
    private bool _isMovingForward = false;
    private bool _isMovingBack = false;
    private bool _isMovingLeft = false;
    private bool _isMovingRight = false;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CheckJumpInput();
        CheckMoveInput();
    }

    private void FixedUpdate()
    {
        HandleJump();
        HandleMovement();
    }

    private void CheckMoveInput()
    {
        CheckInput(ref _isMovingForward, _forwardKey);
        CheckInput(ref _isMovingBack, _backKey);
        CheckInput(ref _isMovingLeft, _leftKey);
        CheckInput(ref _isMovingRight, _rightKey);
    }

    private void CheckInput(ref bool isMoving, KeyCode key)
    {
        isMoving = Input.GetKey(key);
    }

    private void CheckJumpInput()
    {
        if (Input.GetKeyDown(_jumpKey))
            _isJumping = true;
    }

    private void HandleJump()
    {
        if (_isJumping == true)
        {
            _rigidbody.AddForce(0, 5, 0, ForceMode.Impulse);
            _isJumping = false;
        }
    }
    
    private void HandleMovement()
    {
        CheckMove(_isMovingForward, Vector3.forward * 5);
        CheckMove(_isMovingBack, Vector3.back * 5);
        CheckMove(_isMovingLeft, Vector3.left * 5);
        CheckMove(_isMovingRight, Vector3.right * 5);
    }

    private void CheckMove(bool needToMove, Vector3 direction)
    {
        if (needToMove == true)
            _rigidbody.AddForce(direction);
    }
}
