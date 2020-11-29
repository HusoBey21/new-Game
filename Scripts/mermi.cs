using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    public Transform mermiler;
    public float m;
    public Vector3 gorus;
    void Start()
    {
        mermiler = GameObject.FindGameObjectWithTag("Mermilik").transform;
        
        gorus = new Vector3(-7f, transform.position.y, transform.position.z);
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        m += Time.deltaTime;
        
            if (m > 4f)
            {
                if (mermiler != null)
                {
                
                    Transform gun = Instantiate(mermiler, transform.position, Quaternion.identity) as Transform;

                    gun.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;
                    Destroy(gun.gameObject, 10f);
                    m = 0f;
                
                }
            }
        
    }
}
