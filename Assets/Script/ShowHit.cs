using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShowHit : MonoBehaviour
{
    public ParticleSystem particle;
    public void Boom(Vector3 pos)
    {
        particle.transform.position = pos;
        particle.Play();
    }
}
