using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public float pHealth = 100f;
    private float kill = 120f;
    public Text health;
    private void Start()
    {
        health.text = "Health:" + pHealth.ToString();
    }
    public void doDamage()
    {
        pHealth -= 20;
        health.text = "Health:" + pHealth.ToString();
        if (pHealth == 0f)
        {
            SceneManager.LoadScene("Killed");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Enemy")
        {
            Target t = other.GetComponent<Target>();
            t.TakeDamage(120f);
            doDamage();
        }
    }
}
