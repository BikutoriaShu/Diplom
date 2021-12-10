using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class possumDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.name=="player") {
            GameObject.Find("opossum-1").GetComponent<OpossumControl>().PossumDestroy();
        }
    }
}
