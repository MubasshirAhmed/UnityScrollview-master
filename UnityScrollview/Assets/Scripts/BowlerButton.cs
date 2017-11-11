using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlerButton : MonoBehaviour
{
    private int _bowlerID;
    public Image bowlerImage;
    public Text bowlerName;

    public void ValueSetup(BowlerInfo bowlerInfo)
    {
        _bowlerID = bowlerInfo.bowlerID;
        bowlerImage.sprite = bowlerInfo.bowlerImage;
        bowlerName.text = bowlerInfo.bowlerName;
    }

    public void OnButtonClick()
    {
        Debug.Log(_bowlerID);
        Debug.Log(bowlerName.text.ToString());
    }
}
