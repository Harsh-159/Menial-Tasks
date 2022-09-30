using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [Header("Setup")]
    [SerializeField] private GameObject player;
    [SerializeField] private bool MoveRigidBody = true;
    [SerializeField] private float RgbRotationSpeed = 5f;
    [SerializeField] private float TriggerRadius = 5f;
    [SerializeField] private float ChaseSpeed = 5f;
    [SerializeField] private float ChaseDelay = 1f;


    #region private
    private Transform localTrans;
    private bool detected = false;
    private Transform TargetTrans;
    private Vector3 targetPos;
    private Rigidbody localRgb;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        localRgb = GetComponent<Rigidbody>();
        localTrans = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Chase();
    }


    void Chase()
    {
        var speed = ChaseSpeed;

        targetPos = player.transform.position;
        targetPos.y = localTrans.position.y;

        //Move Rigibody;
        if (MoveRigidBody)
        {
            RotateRgb(player.transform);
            localRgb.MovePosition(localRgb.position + localTrans.forward * speed * Time.deltaTime);
        }
    }


    private void RotateRgb(Transform _target)
    {
        Vector3 localTarget = localTrans.InverseTransformPoint(_target.position);

        float angle = Mathf.Atan2(localTarget.x, localTarget.z) * Mathf.Rad2Deg;
        Vector3 eulerAngleVelocity = new Vector3(0, angle, 0);
        Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime * RgbRotationSpeed);
        localRgb.MoveRotation(localRgb.rotation * deltaRotation);
    }
}
