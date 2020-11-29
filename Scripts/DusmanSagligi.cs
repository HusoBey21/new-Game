using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanSagligi : MonoBehaviour
{
    public float saglik = 100f;
    public float k = 0f;
    public void canKazan()
    {
        k += Time.deltaTime;
        if (k >= 6f)
        {
            saglik += 15f;
            k = 0f;
        }
        if (saglik >= 100f)
        {
            saglik = 100f;
        }
    }
     void FixedUpdate()
    {
        canKazan();
    }
    public void canYitir(float hasar)
    {

        saglik -= hasar;
        if(saglik<=0f)
        {
            Destroy(this.gameObject);
            saglik = 100f;
        }
       

    }
}
