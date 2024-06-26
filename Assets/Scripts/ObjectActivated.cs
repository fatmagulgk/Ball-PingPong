using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Nesne Aktif");//OnEnable metodu, bir MonoBehaviour bileşeninin etkinleştirildiği(enabled) anda çağrılan bir Unity metodu olarak kullanılır.Buna ek olarak, bir oyun nesnesi aktif hale getirildiğinde veya sahnede oluşturulduğunda da bu metot çalıştırılır.Bu, bileşenin başlangıç durumunu yapılandırmak veya başka bir eylem gerçekleştirmek için kullanışlı olabilir.
    }
    private void OnDisable()
    {
        Debug.Log("Nesne Devredışı");//OnDisable metodu, bir MonoBehaviour bileşeninin devre dışı bırakıldığı(disabled) anda çağrılan bir Unity metodu olarak kullanılır.Buna ek olarak, bir oyun nesnesi devre dışı bırakıldığında veya sahneden kaldırıldığında da bu metot çalıştırılır.Bu, bileşenin devre dışı bırakıldığında yapılması gereken temizleme işlemleri veya başka bir eylem gerçekleştirmek için kullanışlı olabilir.
    }
}
