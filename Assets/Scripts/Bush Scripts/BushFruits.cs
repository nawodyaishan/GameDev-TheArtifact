using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushFruits : MonoBehaviour
{
    [SerializeField]
    private int[] amountPerType;

    [SerializeField]
    private float[] respawnTime;


    private BushVisual bushVisual;

    private bool hasFruits;
    private float timer;

    private void Awake()
    {
        bushVisual = GetComponent<BushVisual>();

        // Randomly initiallizes some bushes and fruits
        if(Random.Range(0,2 )==0)
        {
            hasFruits = false;
            timer = Time.time + respawnTime[(int)bushVisual.GetBushVariant()];

        }
    }

}// class
