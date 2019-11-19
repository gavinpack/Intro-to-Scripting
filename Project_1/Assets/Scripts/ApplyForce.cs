using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody _rb;
    public Vector3 forces;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        _rb.AddForce(forces);
    }
}
