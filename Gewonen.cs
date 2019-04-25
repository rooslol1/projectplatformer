using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gewonen : MonoBehaviour
{

    public GameObject Button, TextWin;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "winner")
        {

            Button.SetActive(true);
            TextWin.SetActive(true);
            gameObject.SetActive(false);

        }
    }
}