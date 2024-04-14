using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomPositionObjectControl : MonoBehaviour
{
    public List<Vector3> Positions;//Unity'de Vector3, üç boyutlu uzayda konum ve yönlendirmeyi temsil etmek için kullanýlan bir veri tipidir. Bu vektör, x, y ve z koordinatlarýndan oluþur ve genellikle nesnelerin konumunu, hareketini veya yönelimini belirtmek için kullanýlýr.
    int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Vector3 newRandomPosition = RandomPosition();
            Debug.Log(newRandomPosition);
            transform.position = newRandomPosition;
            Positions.Remove(newRandomPosition);

        }
    }
    int RandomIndex()
    {
        return Random.Range(0, Positions.Count);
    }
    Vector3 RandomPosition()
    {
        Vector3 randomPosition = Positions[RandomIndex()];//Unity'de Vector3, üç boyutlu uzayda konum ve yönlendirmeyi temsil etmek için kullanýlan bir veri tipidir. Bu vektör, x, y ve z koordinatlarýndan oluþur ve genellikle nesnelerin konumunu, hareketini veya yönelimini belirtmek için kullanýlýr.

        return randomPosition;
    }

}
