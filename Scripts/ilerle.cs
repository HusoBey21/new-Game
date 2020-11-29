using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilerle : MonoBehaviour
{
    public Transform hedef;
    public Vector3 solKonum,sagKonum;
    public void Start()
    {
        hedef = GameObject.FindGameObjectWithTag("Oyun").transform;
        solKonum = new Vector3(10f,hedef.position.y,hedef.position.z);
        sagKonum = new Vector3(-10f, hedef.position.y, hedef.position.z);
    } 

     void FixedUpdate()
    { 
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, transform.position.x, 10f), transform.position.y, transform.position.z);
        
        if (hedef.rotation.y <=0f)
        {
            transform.Translate(Vector3.right*1f*Time.deltaTime);
        }
        if(hedef.rotation.y > 0f)
        {
            transform.Translate(Vector3.left*1f*Time.deltaTime);
        }
        
    }
}
