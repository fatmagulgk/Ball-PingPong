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
        //Invoke("CreateCylinder", 2f);// Bir i�levi bir s�re gecikme sonras�nda veya belirli aral�klarla �a��rmak istedi�inizde Invoke kullanabilirsiniz.
        StartCoroutine(CloseOrOpen());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {              //(Prerfab Obje,Pozisyon,Potasyon)
            Instantiate(CubePrefab,newPosition,Quaternion.identity);
            //"Instantiate" Bu terim, Unity'de bir nesnenin veya ��enin �rne�ini olu�turmay� ifade eder. Bir ��e veya nesnenin belirli bir anl�k durumunu kopyalayarak, ayn� �zelliklere sahip yeni bir �rne�ini yaratmak i�in kullan�l�r.
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
