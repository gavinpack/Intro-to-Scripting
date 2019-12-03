using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody _rb;
    public Vector3Data forceDirection;
    public float force = 3f;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(forceDirection.value*force);
    }

    private void OnCollisionEnter(Collision other)
    {
        
    }
}
