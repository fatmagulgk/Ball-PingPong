using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class BallControl : MonoBehaviour
{
    private float Vertical;
    private float VerticalZ;
    private float Horizontal;
    private float RepetitionAmount;
    Vector3 startPosition;
    Vector3 endPosition;
    float lerpSpeed = 2f;
    float repeatSpeed = 2.0f;
    float repeatRange = 5.0f;
    float minX = 0.0f;
    float maxX = 20.0f;

    float speed = 3.0f;
    float zControl;
    float delayTime;
    float perlinSpeed;
    float perlinScale;


    private int _number = -5;
    private void Awake()
    {
        startPosition = transform.position;
        endPosition = new Vector3(Random.Range(startPosition.x, startPosition.x + 10), startPosition.y, startPosition.z);
        perlinScale = Random.Range(0, 10);
        Debug.Log("objenin baslangic pozisyonu :" + startPosition);
        Debug.Log("objenin bitis pozisyonu :" + endPosition);
        Vertical = Random.Range(0, 10);
        VerticalZ = Random.Range(-5, 5);
        RepetitionAmount = Random.Range(1, 6);
        zControl = Random.Range(1, 2);

        perlinSpeed = Random.Range(0, 8);

    }
    private void Start()
    {
       
        //    int _reverse = Mathf.Abs(_number);//Sayini tam tersi olan isaretiyle dondurur.
        //    Debug.Log(_reverse);
        //    Debug.Log(Mathf.Floor(20.7f));//Sayiyi kendisine yuvarlar.Virgulden sonra ne oldugu onemli degildir.
        //    Debug.Log(Mathf.Ceil(4.3f));//Sayiyi kendinden sonrakine yuvarlar
        //    Debug.Log(Mathf.Round(2.3f));//Sayiyi eger 5 ten kucukse kendisine buyukse kendinden sonraki sayiya yuvarlar.
        //Debug.Log(Mathf.Min(1, 5));//Küçük olaný döndürür
        //Debug.Log(Mathf.Max(1, 5));//Büyük olaný döndürür
      
    }
    private void Update()
    {
        //float angle = Mathf.LerpAngle(minX, maxX, Time.time);//Belirlenen rotasyona nesnenin yönünü deðiþtirir.
        //transform.eulerAngles = new Vector3(0, angle, 0);

        BallHzStart();

    }

    private void FixedUpdate()
    {

        float t = Mathf.PingPong(Time.time * lerpSpeed, 1.0f);//Belirli aralikta surekli ileri geri yaptirmak.
        transform.position = new Vector3(Mathf.Lerp(startPosition.x, endPosition.x, t), transform.position.y, transform.position.z);//Bu fonksiyon, iki deger arasinda lineer bir gecis yapmanizi saglar.

        float x = transform.position.x + Mathf.PerlinNoise(Time.time * perlinSpeed, 0.0f) * perlinScale;//x duzleminde rastgele tiresim yaptýrýyor.
        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        //float x1 = Mathf.Repeat(Time.time * repeatSpeed, repeatRange * 2) - repeatRange;//Duz bir sekilde belirlenen konuma gider ýsýnlanarak geri doner.
        //transform.position = new Vector3(x1, transform.position.y, transform.position.z);

        //float x2 = transform.position.x + speed * Time.deltaTime;//Belirlenen sýnýrlarýn dýþýna çýkmaz.
        //x2 = Mathf.Clamp(x, minX, maxX);
        //transform.position = new Vector3(x2, transform.position.y, transform.position.z);






    }

    IEnumerator BallHz()
    {
        delayTime = Random.Range(1, 3);
        float x = transform.position.x;// Objenin zikzak yapmasini saðlýyor.//Cos versiyonunda daire ciziyor.
        x += 0.1f;
        //float x = Mathf.Sin(Time.time * RepetitionAmount) * Horizontal;
        float y = Mathf.Sin(Time.time * RepetitionAmount) * Vertical;
        float z = transform.position.z + Mathf.Sin(Time.time * zControl) * delayTime;
        transform.position = new Vector3(x, y, z);
        yield return null;

    }
    void BallHzStart()
    {
        StartCoroutine(BallHz());

    }
   
    
}
