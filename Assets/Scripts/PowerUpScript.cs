using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    [SerializeField] private GameObject[] _ghosts = new GameObject[4];
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach(var ghost in _ghosts)
        {
            //TODO: SCARE MODE
        }
        //TODO: Music change

    }
}
