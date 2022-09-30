using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRobot : MonoBehaviour
{
    public GameObject fire;
    public GameObject pointA;
    public GameObject pointB;
    public GameObject pointC;
    public GameObject pointD;
    public Animator rleg;
    public Animator lleg;
    public Animator head;
    public Animator lid;
    public Animator engine;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Openhead();
        Openlegs();
        Walkstart();
    }

    // Update is called once per frame
    void Update()
    {
        //OPEN and CLOSE LEGs
        

    }

    void Openlegs()
    {
        rleg.SetBool("open", true);
        lleg.SetBool("open", true);
    }
    void Foldlegs()
    {
        rleg.SetBool("open", false);
        lleg.SetBool("open", false);
    }
    void Onengine()
    {
        engine.SetBool("ON", true);
    }
    void Offengine()
    {
        engine.SetBool("ON", false);
    }
    
    void EngineOn()
    {
        Instantiate(fire, pointA.transform.position, pointA.transform.rotation,pointA.transform);
        Instantiate(fire, pointB.transform.position, pointB.transform.rotation,pointB.transform);
        Instantiate(fire, pointC.transform.position, pointC.transform.rotation,pointC.transform);
        Instantiate(fire, pointD.transform.position, pointD.transform.rotation,pointD.transform);
    }

    void EngineOff()
    {
        Destroy(pointA.transform.Find("FireEffect(Clone)").gameObject);
        Destroy(pointB.transform.Find("FireEffect(Clone)").gameObject);
        Destroy(pointC.transform.Find("FireEffect(Clone)").gameObject);
        Destroy(pointD.transform.Find("FireEffect(Clone)").gameObject);
    }
    void Openhead()
    {
        head.SetBool("open", true);
    }
    void Closehead()
    {
        head.SetBool("open", false);
    }
    void Walkstart()
    {
        rleg.SetBool("walk", true);
        lleg.SetBool("walk", true);
    }
    void Stopwalk()
    {
        rleg.SetBool("walk", false);
        lleg.SetBool("walk", false);
    }
    void Openlid()
    {
        lid.SetBool("open", true);
    }
    void Closelid()
    {
        lid.SetBool("open", false);
    }
}
