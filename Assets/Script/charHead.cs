using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charHead : MonoBehaviour
{
    float dam = 60f;
    public Target target;
    [SerializeField] Transform body;
    private float ypos;
    public void DD()
    {
        target.TakeDamage(dam);
    }
    private void Start()
    {
        ypos = transform.position.y;
    }
    private void Update()
    {
        transform.position = new Vector3(body.position.x, ypos, body.position.z);
    }
}
