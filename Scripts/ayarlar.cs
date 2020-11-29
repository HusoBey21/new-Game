using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ayarlar : MonoBehaviour
{
    public void oyunuAc()
    {
        SceneManager.LoadScene(1);
    }
    public void oyundanCik()
    {
        Application.Quit();
    }
    public void oyunYukle()
    {
        PlayerPrefs.GetString("sahne"); //Sahneyi yüklemesi gerek.
    }
}
