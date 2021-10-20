using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text Gems;
    public Text Cherry;
    public Text GemsFinish;
    public static int gems=0;
    public static int cherry=0;
    public static int gemsfinish=0;
    void Update()
    {
        Gems.text=gems.ToString()+" Gems";
        GemsFinish.text=gemsfinish.ToString()+" Gems";
        Cherry.text =  Math.Round(Controller.timeleft).ToString()+".00";
    }
}
