using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float bodyDamage=20f;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBull();
        }
    }
    void ShootBull() 
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
            Debug.Log(hit.transform.gameObject.tag);

            charHead cr = hit.transform.GetComponent<charHead>();
            if (cr != null)
            {
                cr.DD();
            }
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(bodyDamage);
            }
            ShowHit sh = hit.transform.GetComponent<ShowHit>();
            if (sh != null)
            {
                sh.Boom(hit.point);
            }
            
        }
        
    }
}
