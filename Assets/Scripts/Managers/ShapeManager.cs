using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    //[SerializeField] => Eger bir private degiskeni [SerializeField] yaparsak unity editorunde ona ulasabilir ve uzerinde duzenlemeler yapabiliriz ancak o degisken diger siniflar icin hala private durumda kalacakt�r.
    public int score;
    public GameObject Sphere;
    public GameObject Cube;// GameObject t�r�n� sahnede kulland���m�z objelere eri�mek i�in kullan�r�z.
    public GameObject Capsule;
    int easy = 0;
    int medium = 1;
    int hard = 2;
    int currentLevel;
    int colorCode;
    MeshRenderer _cubeRenderer;
    public GameObject Cylinder;
    public int Damage;
    public int Hp;
    public GameObject[] Cyilinders;


    private void Awake()//Awake metodu, bir bile�enin olu�turulma an�nda yap�lmas� gereken ba�lang�� ayarlar�n� ger�ekle�tirmek i�in kullan�l�r ve Start metodundan �nce �a�r�l�r.
    {
        _cubeRenderer = Cube.GetComponent<MeshRenderer>();
    }

    void Start()//Start fonksiyonu, bir GameObject'in aktifle�tirildi�i anda sadece bir kez �a�r�l�r.Genellikle ba�lang�� ayarlar� ve ba�lang��ta yap�lmas� gereken di�er i�lemler bu fonksiyon i�inde ger�ekle�tirilir.
    {

        Sphere.GetComponent<MeshRenderer>().material.color = Color.green;

        
        InvokeRepeating("IEStart", 0f, 1f);//InvokeRepeating, Unity'de bir metodu belirli aral�klarla �a��rmak i�in kullan�lan bir y�ntemdir. Bu y�ntem, bir metodun belirli bir s�re gecikme sonras�nda ba�lamas�n� ve ard�ndan belirli aral�klarla tekrarlanmas�n� sa�lar. Bu �zellikle d�zenli olarak tekrarlanmas� gereken oyun olaylar� i�in kullan��l�d�r. 
        Cyilinders = AllCylinder();
 
    }

    void Update()//Update fonksiyonu, her frame g�ncellendi�inde �a�r�l�r.Oyun i�inde s�rekli olarak g�ncellenen i�lemler, kullan�c� giri�i kontrol� ve �e�itli oyun durumlar� bu fonksiyon i�inde kontrol edilir.
    {

        #region Sphere
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 5;
            if (score % 2 == 0)
            {
                int randomNumber = Random.Range(0, 2);
                switch (randomNumber)
                {
                    case 0:
                        Sphere.GetComponent<MeshRenderer>().material.color = Color.red;
                        Debug.Log("K�rm�z�" + score);
                        /*Debug console ekran�nda bir bilgi mesaj� almak istedi�imizde kulland���m�z versiyondur.
                         Debug.LogWarning("Bu bir uyar� mesaj�d�r.");
                        Debug.LogError("Bu bir hata mesaj�d�r.");
                         */
                        break;
                    case 1:
                        Sphere.GetComponent<MeshRenderer>().material.color = Color.black;//GetCompenent => Belirtilen objenin belirtilen �zelli�ine ula�arak manip�le etmemizi sa�lar.
                        Debug.Log("Siyah" + score);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Sphere.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.Log("Ye�il");
            }
        }
        #endregion
        #region Capsule

        if (Input.GetKeyDown(KeyCode.Alpha1))//GetKeyDown => Belirtilen tu�a bas�l�p bas�lmad���n� kontrol eder.
        {
            colorCode = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            colorCode = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            colorCode = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            colorCode = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            colorCode = 5;
        }


        switch (colorCode)
        {
            case 1:
                Capsule.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case 2:
                Capsule.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            case 3:
                Capsule.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case 4:
                Capsule.GetComponent<MeshRenderer>().material.color = Color.cyan;
                break;
            case 5:
                Capsule.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            default:
                break;
        }
        #endregion

        if (Input.GetKeyDown(KeyCode.Q))
        {
            DamageControl();//"Destroyer metodu" terimi Unity oyun geli�tirme ortam�nda ��elerin (game objects) bellekten silinmesi veya yok edilmesi i�in kullan�lan bir metodun ad�n� ifade eder.
        }
        

    }
    #region Cube
    IEnumerator CubeColorControl()//IEnumerator(Enumerator), C# dilinde bir aray�z (interface) olarak kullan�lan ve genellikle d�ng�sel i�lemleri y�netmek i�in kullan�lan bir yap�d�r.
    {

        currentLevel = Random.Range(0, 3);


        if (currentLevel == easy)
        {
            _cubeRenderer.material.color = Color.green;
        }
        else if (currentLevel == medium)
        {
            _cubeRenderer.material.color = Color.blue;
        }
        else if (currentLevel == hard)
        {
            _cubeRenderer.material.color = Color.yellow;
        }
        else
        {
            _cubeRenderer.material.color = Color.cyan;
        }
        yield return null;//IEnumerator'�n kullan�lmas�, genellikle yield return ifadesi ile birlikte gelir ve bu ifade, d�ng�deki her bir ad�m�n ard�ndan ge�ici bir duraklama (yield) sa�lar. 
    }
    void IEStart()
    {
        StartCoroutine(CubeColorControl());//IEnumerator'� bailatmak i�in kullan�l�r.
        
    }
    #endregion
    #region Cylinder
    void DamageControl()

    {
        Hp = Hp - Damage;
        if (Hp <= 0)
        {   
            Hp = 0;
            Destroy(this.Cylinder);
        }
       
    }
    #endregion
    #region Tag Cylinder
    GameObject[] AllCylinder()
    {
        GameObject[] _allClinder = GameObject.FindGameObjectsWithTag("Cylinder");// Unity'de "tag" (etiket) terimi, bir oyun nesnesine veya ��esine �zel bir tan�mlay�c� atamak i�in kullan�lan bir �zelliktir. Bu tan�mlay�c�lar, belirli nesneleri gruplamak, tan�mak veya i�lemek i�in kullan�labilir.
        foreach (var cylinder in _allClinder)
        {
            cylinder.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        return _allClinder;
    }
    #endregion
}

