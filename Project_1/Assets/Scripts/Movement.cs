using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float gravity = -3f;
    public float jumpSpeed = 10f;
    
    private Vector3 position;
    public CharacterController controller;
    
    void Update()
    {
        position.x = speed*Input.GetAxis("Horizontal");

        if (!controller.isGrounded)
        {
            position.y = gravity;
        }
        else
        {
            position.y = 0f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            position.y = jumpSpeed;
        }
            controller.Move(position * Time.deltaTime);
    }
}
