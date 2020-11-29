using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ateskes : MonoBehaviour
{
    public Transform y;
    private void Start()
    {
        y = GameObject.FindGameObjectWithTag("Oyun").transform; //Gereken nesne tanımlandı
    }

    // 2020 sonlanıyor yavaştan
    void Update()
    {


        if (y != null)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10f, transform.position.x), transform.position.y, transform.position.z);
            transform.position += Vector3.left * 2f * Time.deltaTime;

            transform.LookAt(y); //Buna odaklanıyor.
            
        }
        

    }
    
   
}

    
