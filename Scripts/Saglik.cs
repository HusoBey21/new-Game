using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Saglik : MonoBehaviour
{
    public float can=100f;
    public Text ad;
    public float x;
    public void Start()
    {
        ad = GameObject.FindGameObjectWithTag("Metin").GetComponent<Text>();
    }

    public void Update()
    {
        canKazan();
    }
    public void CanYitir(float hasar)
    {
        can -= hasar;
        if(can >=0 && can<15)
        {
            ad.text = "Health is reducing";
        }
        if(can < 0f)
        {
            SceneManager.LoadScene(1);
            can = 0f;
        }

    }
    public void canKazan()
    {
        x += Time.deltaTime; //Zaman kazanma
        if (x > 10f)
        {
            can += 5f;
            x = 0f;
        }
        if(can >=100f)
        {
            can = 100f;
        }
    }
}
