using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HedefeDokun : MonoBehaviour
{
    public Vector3 z;
    public Transform k;
    public GameObject n;
    public float s;
    public Text vurus;
    public AudioClip asd;
    public void Start()
    {
        k = GameObject.FindGameObjectWithTag("Asker").transform;
        n = GameObject.FindGameObjectWithTag("Oyun");
        vurus = GameObject.FindGameObjectWithTag("YeniMetin").GetComponent<Text>();
        
 
        
        z = new Vector3(-10f, n.transform.position.y, k.position.z);
        
    }
     void FixedUpdate()
    {
        s += Time.deltaTime;
        
           
            Debug.Log("Salı");
            RaycastHit2D vur = Physics2D.Raycast(transform.position,z,10f,LayerMask.GetMask("Mermi"));

        if (n.transform != null)
        {

            if (vur.transform != null && vur.transform == n.transform)
            {
                Debug.Log(vur.transform.name);
                Debug.Log("17 Kasım 2020");
                if (s > 10f)
                {
                    Debug.Log("Aç koydular beni");
                    vur.transform.GetComponent<Saglik>().CanYitir(10f);
                    AudioSource a = vur.transform.gameObject.GetComponent<AudioSource>(); //Ses kaynağı sağlandı.
                    StartCoroutine(yazi());
                    a.clip = asd;
                    if(!a.isPlaying)
                    {
                        a.Play(); //Oynat baba
                    }
                       
                    a.Play();
                    
                    StartCoroutine(animasyon(n.GetComponent<Animator>()));
                    s= 0f;
                }

            }
        }
        
    }
    IEnumerator animasyon(Animator a)
    {
        a.enabled = true;
        yield return new WaitForSeconds(.5f);
        a.SetBool("isWounded", true);
        yield return new WaitForSeconds(.5f);
        a.SetBool("isWounded", false);
           
    }
    IEnumerator yazi()
    {
        vurus.enabled = true;
        yield return new WaitForSeconds(.7f);
        vurus.text = "Enemy Hit";
        yield return new WaitForSeconds(.7f);
    }
}
