using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveAndDestroyer : MonoBehaviour
{
    public GameObject Cube;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Cube.SetActive(false);// "SetActive" ifadesi, Unity'de bir oyun nesnesinin etkinle�tirilip devre d��� b�rak�lmas� i�in kullan�l�r. Bu, oyun i�inde nesnelerin g�r�n�r veya g�r�nmez olmas�n� kontrol etmek i�in yayg�n olarak kullan�l�r.
            Destroy(Cube, 2f);//Unity'de, bir oyun nesnesini veya bile�eni yok etmek i�in Destroy metodu kullan�l�r. Bu metot, bir nesneyi oyun sahnesinde ortadan kald�rmak i�in kullan�l�r. 
        }
    }
}
