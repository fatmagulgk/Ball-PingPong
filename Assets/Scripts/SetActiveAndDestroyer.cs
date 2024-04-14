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
            Cube.SetActive(false);// "SetActive" ifadesi, Unity'de bir oyun nesnesinin etkinleþtirilip devre dýþý býrakýlmasý için kullanýlýr. Bu, oyun içinde nesnelerin görünür veya görünmez olmasýný kontrol etmek için yaygýn olarak kullanýlýr.
            Destroy(Cube, 2f);//Unity'de, bir oyun nesnesini veya bileþeni yok etmek için Destroy metodu kullanýlýr. Bu metot, bir nesneyi oyun sahnesinde ortadan kaldýrmak için kullanýlýr. 
        }
    }
}
