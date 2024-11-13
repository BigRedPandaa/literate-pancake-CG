using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed = 5f;

    private CharacterController _controller;
    private Vector3 _moveDirection;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        MovingPlayer();
    }

    void MovingPlayer()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontal, 0, vertical).normalized;

        _moveDirection = transform.TransformDirection(inputDirection);

        _controller.Move(_moveDirection * moveSpeed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");
    }
}