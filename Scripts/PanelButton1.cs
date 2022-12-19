using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelButton1 : MonoBehaviour
{
    public GameObject boat1;
    [SerializeField] public TextMeshProUGUI answer1;
    //[SerializeField] public GameObject trawlercard;
    [SerializeField] public DefaultObserverEventHandler check1;

public void testImageCS()
    {

        
        Debug.Log(check1.mObserverBehaviour.TargetName);    
        /*if( (boat1.gameObject.name == "CruiseShipCard" || boat1.gameObject.name =="CruiseShipCard2") && (check1.mObserverBehaviour.TargetName=="passenger_boat" || check1.mObserverBehaviour.TargetName == "passenger_boat2"))
        {
            //Debug.Log(boat.gameObject.name);
            answer1.text = "[CORRECT]";
        }
        else
        {
            Debug.Log(boat1.gameObject.name);
            answer1.text = "[TRY AGAIN]";
        }*/
    }
}
