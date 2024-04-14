
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameTimeManager : MonoBehaviour
{
    //public OperationManager m;
    private void Start()
    {
        //m=Object.FindObjectOfType<OperationManager>();//ayný iþlevde //unityengine kütüphanesini kullanýrken systemi kullanmak saðlýklý deðil çakýþabilir.Ve nesne oluþturduðun clasla çaðýrdýðýn class ayný sahnede olmalý.
        ////m=GameObject.Find("OperationManager").GetComponent<OperationManager>();//Find metodyla sahnedeki opbjeyi buluyoruz.
        //Debug.Log(m.number1);
    }
    #region TimerCode
    //public TextMeshProUGUI countdownText;
    //private void Start()
    //{
    //    StartMetot();
    //}

    //IEnumerator TimeControl(float totalSeconds)
    //{
    //    float temp = totalSeconds;
    //    while (totalSeconds >= 0)
    //    {
    //        string timeText;
    //        TimeSpan timeSpan = TimeSpan.FromSeconds(Mathf.Max(totalSeconds, 0));
    //        if (totalSeconds < 60)
    //        {
    //            if (temp >= 60)
    //            {
    //                timeText = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
    //            }
    //            else
    //            {
    //                timeText = string.Format("{0:D2}", timeSpan.Seconds);
    //            }

    //        }
    //        else if (totalSeconds < 3600)
    //        {
    //            if (temp >= 3600)
    //            {
    //                timeText = string.Format("{0:D2}:{1:D2}:{2:D2}",
    //            timeSpan.Hours,
    //            timeSpan.Minutes,
    //            timeSpan.Seconds);
    //            }
    //            else
    //            {
    //                timeText = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
    //            }

    //        }
    //        else
    //        {
    //            timeText = string.Format("{0:D2}:{1:D2}:{2:D2}",
    //            timeSpan.Hours,
    //            timeSpan.Minutes,
    //            timeSpan.Seconds);
    //        }




    //        countdownText.text = timeText;


    //        yield return new WaitForSeconds(1);

    //        totalSeconds--;
    //        if (totalSeconds == 0)
    //        {
    //            Debug.Log("zaman doldu");
    //        }
    //    }

    //}
    //void StartMetot()
    //{
    //    StartCoroutine(TimeControl(65));
    //}


    #endregion


}
