using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Nesne Aktif");//OnEnable metodu, bir MonoBehaviour bile�eninin etkinle�tirildi�i(enabled) anda �a�r�lan bir Unity metodu olarak kullan�l�r.Buna ek olarak, bir oyun nesnesi aktif hale getirildi�inde veya sahnede olu�turuldu�unda da bu metot �al��t�r�l�r.Bu, bile�enin ba�lang�� durumunu yap�land�rmak veya ba�ka bir eylem ger�ekle�tirmek i�in kullan��l� olabilir.
    }
    private void OnDisable()
    {
        Debug.Log("Nesne Devred���");//OnDisable metodu, bir MonoBehaviour bile�eninin devre d��� b�rak�ld���(disabled) anda �a�r�lan bir Unity metodu olarak kullan�l�r.Buna ek olarak, bir oyun nesnesi devre d��� b�rak�ld���nda veya sahneden kald�r�ld���nda da bu metot �al��t�r�l�r.Bu, bile�enin devre d��� b�rak�ld���nda yap�lmas� gereken temizleme i�lemleri veya ba�ka bir eylem ger�ekle�tirmek i�in kullan��l� olabilir.
    }
}
