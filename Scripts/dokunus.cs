using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//22 Kasım 2020 Pazar
public class dokunus : MonoBehaviour
{
    
    public Animation ast;
    public void Start()
    {
        
        ast = GameObject.FindGameObjectWithTag("Asker").GetComponent<Animation>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Asker"))
        {
            Debug.Log("Askere dokun");
            collision.gameObject.GetComponent<DusmanSagligi>().canYitir(10f);
           AudioSource a= collision.gameObject.GetComponent<AudioSource>();
            if(!a.isPlaying)
            {
                a.Play();
            }

            if (!ast.isPlaying)
            {
                ast.CrossFade("baska", 5f); //Deneyeceğiz.Hiçbir fikrim yok ne yaptığına dair.
            }

            
        }
        

    }
   
}
