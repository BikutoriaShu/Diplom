using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPscript : MonoBehaviour
{
 public Sprite sprFull;
 public Sprite sprEmpty;
 public Image heart3;
 public Image heart2;
 public Image heart1;
 public Controller cnt;

 void Update() {
     if (cnt.hearts == 3) {
         heart3.sprite =sprFull;
     } else {
         heart3.sprite=sprEmpty;
     }
     switch (cnt.hearts)
     {
         case 3:
            heart3.sprite =sprFull;
            heart2.sprite =sprFull;
            heart1.sprite =sprFull;
         break;
          case 2:
            heart3.sprite =sprEmpty;
            heart2.sprite =sprFull;
            heart1.sprite =sprFull;
         break;
          case 1:
            heart3.sprite =sprEmpty;
            heart2.sprite =sprEmpty;
            heart1.sprite =sprFull;
         break;
         
 
     }
 }

}
