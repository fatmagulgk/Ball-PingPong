using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUp : MonoBehaviour
{
    public GameObject Cube;
    float speed = 10f;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,Cube.transform.position,Time.deltaTime*speed);//Scripti i�ine att���m�z nesnenin Cube objesini takip etmesini sa�l�yor.
    }



}
