using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InstantiateAndInvoke : MonoBehaviour
{

    public GameObject CubePrefab;
    public GameObject CylinderPrefab;
    [SerializeField] private GameObject Sphere;

    Vector3 newPosition;
    private void Awake()
    {
        newPosition= transform.position;

    }
    private void Start()
    {
        //Invoke("CreateCylinder", 2f);// Bir iþlevi bir süre gecikme sonrasýnda veya belirli aralýklarla çaðýrmak istediðinizde Invoke kullanabilirsiniz.
        StartCoroutine(CloseOrOpen());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {              //(Prerfab Obje,Pozisyon,Potasyon)
            Instantiate(CubePrefab,newPosition,Quaternion.identity);
            //"Instantiate" Bu terim, Unity'de bir nesnenin veya öðenin örneðini oluþturmayý ifade eder. Bir öðe veya nesnenin belirli bir anlýk durumunu kopyalayarak, ayný özelliklere sahip yeni bir örneðini yaratmak için kullanýlýr.
            newPosition.x +=3;
            
        }
    }
    void CreateCylinder()
    {
        Instantiate(CylinderPrefab, transform.position, Quaternion.identity);
    }
    IEnumerator CloseOrOpen()
    {
        yield return new  WaitForSeconds(2f);
        
        Sphere.SetActive(false);

        yield return new WaitForSeconds(2f);
        Sphere.SetActive(true);
    }
}
