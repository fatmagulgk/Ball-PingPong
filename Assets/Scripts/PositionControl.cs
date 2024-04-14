using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomPositionObjectControl : MonoBehaviour
{
    public List<Vector3> Positions;//Unity'de Vector3, �� boyutlu uzayda konum ve y�nlendirmeyi temsil etmek i�in kullan�lan bir veri tipidir. Bu vekt�r, x, y ve z koordinatlar�ndan olu�ur ve genellikle nesnelerin konumunu, hareketini veya y�nelimini belirtmek i�in kullan�l�r.
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
        Vector3 randomPosition = Positions[RandomIndex()];//Unity'de Vector3, �� boyutlu uzayda konum ve y�nlendirmeyi temsil etmek i�in kullan�lan bir veri tipidir. Bu vekt�r, x, y ve z koordinatlar�ndan olu�ur ve genellikle nesnelerin konumunu, hareketini veya y�nelimini belirtmek i�in kullan�l�r.

        return randomPosition;
    }

}
