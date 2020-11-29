using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanHareketi : MonoBehaviour
{
    public Animator anim;
    public void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Asker").GetComponent<Animator>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        anim.enabled = false;
        float k = Mathf.Clamp(transform.position.x, -14f, transform.position.x);
        transform.position = new Vector3(k, transform.position.y, transform.position.z);

        transform.position += Vector3.left * 1f * Time.deltaTime;
        anim.SetBool("isWalking", true);
      
       
    }
   

}
