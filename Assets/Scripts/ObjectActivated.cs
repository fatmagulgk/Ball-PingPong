using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Nesne Aktif");//OnEnable metodu, bir MonoBehaviour bileþeninin etkinleþtirildiði(enabled) anda çaðrýlan bir Unity metodu olarak kullanýlýr.Buna ek olarak, bir oyun nesnesi aktif hale getirildiðinde veya sahnede oluþturulduðunda da bu metot çalýþtýrýlýr.Bu, bileþenin baþlangýç durumunu yapýlandýrmak veya baþka bir eylem gerçekleþtirmek için kullanýþlý olabilir.
    }
    private void OnDisable()
    {
        Debug.Log("Nesne Devredýþý");//OnDisable metodu, bir MonoBehaviour bileþeninin devre dýþý býrakýldýðý(disabled) anda çaðrýlan bir Unity metodu olarak kullanýlýr.Buna ek olarak, bir oyun nesnesi devre dýþý býrakýldýðýnda veya sahneden kaldýrýldýðýnda da bu metot çalýþtýrýlýr.Bu, bileþenin devre dýþý býrakýldýðýnda yapýlmasý gereken temizleme iþlemleri veya baþka bir eylem gerçekleþtirmek için kullanýþlý olabilir.
    }
}
