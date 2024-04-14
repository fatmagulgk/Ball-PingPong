using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class OperationManager : MonoBehaviour
{


    public int number1 = 80;
    int number2 = 9;
    int toplam;
    // Start is called before the first frame update
   
    void Start()
    {
        //toplam = number1 + number2;
        //Debug.Log(toplam);

        //number1++;
        //number2--;
        //Debug.Log(number1);
        //Debug.Log(number2);
        Debug.Log(number1 % number2+"mod alma");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
