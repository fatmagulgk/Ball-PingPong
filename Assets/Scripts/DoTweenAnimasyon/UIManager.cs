using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform panel1, panel2;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveIt()
    {
        panel1.DOAnchorPos(new Vector2(500, 0), 0.5f).SetEase(Ease.InBack);
        panel2.DOAnchorPos(Vector2.zero, 0.5f).SetDelay(0.5f).SetEase(Ease.OutBack);
    }
}
