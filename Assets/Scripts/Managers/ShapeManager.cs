using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    //[SerializeField] => Eger bir private degiskeni [SerializeField] yaparsak unity editorunde ona ulasabilir ve uzerinde duzenlemeler yapabiliriz ancak o degisken diger siniflar icin hala private durumda kalacaktýr.
    public int score;
    public GameObject Sphere;
    public GameObject Cube;// GameObject türünü sahnede kullandýðýmýz objelere eriþmek için kullanýrýz.
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


    private void Awake()//Awake metodu, bir bileþenin oluþturulma anýnda yapýlmasý gereken baþlangýç ayarlarýný gerçekleþtirmek için kullanýlýr ve Start metodundan önce çaðrýlýr.
    {
        _cubeRenderer = Cube.GetComponent<MeshRenderer>();
    }

    void Start()//Start fonksiyonu, bir GameObject'in aktifleþtirildiði anda sadece bir kez çaðrýlýr.Genellikle baþlangýç ayarlarý ve baþlangýçta yapýlmasý gereken diðer iþlemler bu fonksiyon içinde gerçekleþtirilir.
    {

        Sphere.GetComponent<MeshRenderer>().material.color = Color.green;

        
        InvokeRepeating("IEStart", 0f, 1f);//InvokeRepeating, Unity'de bir metodu belirli aralýklarla çaðýrmak için kullanýlan bir yöntemdir. Bu yöntem, bir metodun belirli bir süre gecikme sonrasýnda baþlamasýný ve ardýndan belirli aralýklarla tekrarlanmasýný saðlar. Bu özellikle düzenli olarak tekrarlanmasý gereken oyun olaylarý için kullanýþlýdýr. 
        Cyilinders = AllCylinder();
 
    }

    void Update()//Update fonksiyonu, her frame güncellendiðinde çaðrýlýr.Oyun içinde sürekli olarak güncellenen iþlemler, kullanýcý giriþi kontrolü ve çeþitli oyun durumlarý bu fonksiyon içinde kontrol edilir.
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
                        Debug.Log("Kýrmýzý" + score);
                        /*Debug console ekranýnda bir bilgi mesajý almak istediðimizde kullandýðýmýz versiyondur.
                         Debug.LogWarning("Bu bir uyarý mesajýdýr.");
                        Debug.LogError("Bu bir hata mesajýdýr.");
                         */
                        break;
                    case 1:
                        Sphere.GetComponent<MeshRenderer>().material.color = Color.black;//GetCompenent => Belirtilen objenin belirtilen özelliðine ulaþarak manipüle etmemizi saðlar.
                        Debug.Log("Siyah" + score);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Sphere.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.Log("Yeþil");
            }
        }
        #endregion
        #region Capsule

        if (Input.GetKeyDown(KeyCode.Alpha1))//GetKeyDown => Belirtilen tuþa basýlýp basýlmadýðýný kontrol eder.
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
            DamageControl();//"Destroyer metodu" terimi Unity oyun geliþtirme ortamýnda öðelerin (game objects) bellekten silinmesi veya yok edilmesi için kullanýlan bir metodun adýný ifade eder.
        }
        

    }
    #region Cube
    IEnumerator CubeColorControl()//IEnumerator(Enumerator), C# dilinde bir arayüz (interface) olarak kullanýlan ve genellikle döngüsel iþlemleri yönetmek için kullanýlan bir yapýdýr.
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
        yield return null;//IEnumerator'ýn kullanýlmasý, genellikle yield return ifadesi ile birlikte gelir ve bu ifade, döngüdeki her bir adýmýn ardýndan geçici bir duraklama (yield) saðlar. 
    }
    void IEStart()
    {
        StartCoroutine(CubeColorControl());//IEnumerator'ü bailatmak için kullanýlýr.
        
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
        GameObject[] _allClinder = GameObject.FindGameObjectsWithTag("Cylinder");// Unity'de "tag" (etiket) terimi, bir oyun nesnesine veya öðesine özel bir tanýmlayýcý atamak için kullanýlan bir özelliktir. Bu tanýmlayýcýlar, belirli nesneleri gruplamak, tanýmak veya iþlemek için kullanýlabilir.
        foreach (var cylinder in _allClinder)
        {
            cylinder.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        return _allClinder;
    }
    #endregion
}

