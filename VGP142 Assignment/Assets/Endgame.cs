using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{

    public GameObject Endscrn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerTag")
        {
            Endscrn.gameObject.SetActive(true);



        }
    }


}
