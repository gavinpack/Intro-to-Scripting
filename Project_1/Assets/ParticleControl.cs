using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Control : MonoBehaviour
{
    public ParticleSystem particles;

    private void OnMouseDown()
    {
        particles.Emit(100);
    }
}
