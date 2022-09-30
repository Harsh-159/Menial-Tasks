using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour
{
    public Transform parent;
    public Transform recoilMod;
    public GameObject weapon;
    public float maxRecoil_Z = -20f;
    public float recoilSpeed = 10f;
    public float recoil = 0.0f;
 
    void Update()
        {
        weapon.transform.localEulerAngles = new Vector3(weapon.transform.localEulerAngles.x, parent.transform.rotation.y+90f, weapon.transform.localEulerAngles.z);
        if (Input.GetMouseButtonDown(0))
            {
                //every time you fire a bullet, add to the recoil.. of course you can probably set a max recoil etc..
                recoil += 0.1f;
            }

            recoiling();
        }

        void recoiling()
        {
            if (recoil > 0)
            {
                var maxRecoil = Quaternion.Euler(0,90, maxRecoil_Z);
                // Dampen towards the target rotation
                recoilMod.rotation = Quaternion.Slerp(recoilMod.rotation, maxRecoil, Time.deltaTime * recoilSpeed);
                //weapon.transform.localEulerAngles.x = recoilMod.localEulerAngles.x;
                weapon.transform.localEulerAngles = new Vector3(weapon.transform.localEulerAngles.x, weapon.transform.localEulerAngles.y, recoilMod.localEulerAngles.z);
                recoil -= Time.deltaTime;
            }
            else
            {
                recoil = 0;
                var minRecoil = Quaternion.Euler(0, 90, 0);
                // Dampen towards the target rotation
                recoilMod.rotation = Quaternion.Slerp(recoilMod.rotation, minRecoil, Time.deltaTime * recoilSpeed / 2);
                weapon.transform.localEulerAngles = new Vector3(weapon.transform.localEulerAngles.x, weapon.transform.localEulerAngles.y, recoilMod.localEulerAngles.z);
        }
            //transform.rotation = new Vector3(transform.rotation.x, transform.rotation.y + 90f, transform.rotation.z);
        }
}
