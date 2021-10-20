using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryCont : MonoBehaviour
{
    private void OnDestroy(){
        Score.cherry++;
    }
}
