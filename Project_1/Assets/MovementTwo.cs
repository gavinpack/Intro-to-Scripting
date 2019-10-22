using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementTwo : MonoBehaviour
{
    private CharacterController _controller;
    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
    private Vector3 _position;
    private int _jumpCount;
    public int jumpCountMax = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _position.x = moveSpeed*Input.GetAxis("Horizontal");
        _position.y -= gravity;

        if (_controller.isGrounded)
        {
            _position.y = 0;
            _jumpCount = 0;
        }
        
        if (Input.GetButtonDown("Jump") && _jumpCount < jumpCountMax)
        {
            _position.y = jumpSpeed;
            _jumpCount++;
        }

        _controller.Move(_position*Time.deltaTime);
    }
}
