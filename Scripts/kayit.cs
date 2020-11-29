using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kayit : MonoBehaviour
{
    Transform y;
    Saglik ast;
    void Start()
    {
        y = this.transform;
        ast = y.GetComponent<Saglik>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("Kayıt alındı");
            PlayerPrefs.SetFloat("saglik", ast.can);
            PlayerPrefs.SetString("sahne",SceneManager.GetActiveScene().name);
            PlayerPrefs.Save();
        }
    }
}
