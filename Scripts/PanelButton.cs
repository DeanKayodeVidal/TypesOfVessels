using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelButton : MonoBehaviour
{
    //public GameObject boatbtn;
    [SerializeField] public TextMeshProUGUI answer;
    //[SerializeField] public GameObject trawlercard;
    [SerializeField] public DefaultObserverEventHandler check;

public void checkTrawler()
    {
        //Debug.Log(check.mObserverBehaviour.TargetName);
        if ( (check.mObserverBehaviour.TargetName=="trawler" || check.mObserverBehaviour.TargetName == "trawler_boat2"))
        {
            Debug.Log("TRAWLER FOUND");
            //answer.text = "[CORRECT]";
        }
        else
        {
            Debug.Log("TRY AGAIN");
            //answer.text = "[TRY AGAIN]";
        }
    }
}
