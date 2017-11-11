using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BowlerInfo
{
    public int bowlerID;
    public Sprite bowlerImage;
    public string bowlerName;
}

public class BowlerScrollList : MonoBehaviour
{
    public List<BowlerInfo> bowlerInfoList;
    public Transform contentList;
    public GameObject bowlerInfoBtn;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < bowlerInfoList.Count; i++)
        {
            GameObject newBtn = Instantiate(bowlerInfoBtn);
            newBtn.transform.SetParent(contentList);
            BowlerButton bowlerButton = newBtn.GetComponent<BowlerButton>();
            bowlerButton.ValueSetup(bowlerInfoList[i]);
        }
    }
}
