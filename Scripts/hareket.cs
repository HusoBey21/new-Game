
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hareket : MonoBehaviour
{
    public Animator anim;
    public Transform askerler,parcacik;
    public AudioSource a;
    public AudioClip ba;

    private void Awake()
    {
        a = this.GetComponent<AudioSource>();
        askerler = GameObject.FindGameObjectWithTag("Asker").transform;
        parcacik = GameObject.FindGameObjectWithTag("Parçacık").transform;
        anim = this.GetComponent<Animator>();
        transform.position = new Vector3(-6.13f, -4.03f,transform.position.z);
        anim.enabled = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       
        
        float b = Mathf.Clamp(transform.position.x, -6.5f, 6.5f);
        transform.position = new Vector3(b, transform.position.y, transform.position.z);

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180f, transform.eulerAngles.z);
            

            transform.position += Vector3.left * 2f * Time.deltaTime;
            
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.position.y,transform.eulerAngles.z);

            transform.position += Vector3.right * 2f * Time.deltaTime;

        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,90f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,0f);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.enabled = true;
            if (anim.enabled)
            {
                Debug.Log("Beni vur");
                anim.SetBool("isJumping", true);
                StartCoroutine(kapat());
            }
            
                
            
        }
        
        if(Input.GetMouseButtonDown(0))
        {
            if(parcacik != null)
            {
                Transform parca = Instantiate(parcacik,transform.position,Quaternion.identity) as Transform; //Parçacık hareketi sağlanacak.
                Destroy(parca.gameObject, 10f);
                a.clip = ba;
                if(!a.isPlaying)
                {
                    a.Play();
                }
            }
            anim.enabled = true;
            if (anim.enabled)
            {
                anim.SetBool("isAttacking", true);
            }
            StartCoroutine(geriyeDon());
            
        }
        if(Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(0); //Sahneye geri dönüş 
            PlayerPrefs.SetString("sahne", SceneManager.GetActiveScene().name);
            Debug.Log("Sahne kaydedildi");
        }
        
            
        IEnumerator kapat()
        {
            yield return new WaitForSeconds(.4f);
            anim.SetBool("isJumping",false);
            yield return new WaitForSeconds(.4f);
            anim.enabled = false;
        }
        IEnumerator geriyeDon()
        {
            yield return new WaitForSeconds(.6f);
            anim.SetBool("isAttacking", false);
            yield return new WaitForSeconds(.6f);
            anim.enabled = false;
        }

    }
}
