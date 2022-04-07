using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushVisual : MonoBehaviour
{

    [SerializeField] private Sprite[] bushSprites, fruitSprites, drySprtites;

    [SerializeField] private SpriteRenderer[] fruitsRenderers;


    public enum BushVarient { Green, cyan, Yelow }

    private BushVarient bushVarient;

    public float hideTimePerFruit = 0.2f;

    private SpriteRenderer sr;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();

        bushVarient = (BushVarient)Random.Range(0, bushSprites.Length);
        sr.sprite = bushSprites[(int)bushVarient];

        if (Random.Range(0, 2) == 1)
            sr.flipX = true;

        for (int i = 0; i < fruitsRenderers.Length; i++)
        {
            fruitsRenderers[i].sprite = fruitSprites[(int)bushVarient];
            //fruitsRenderers[i].enabled = false;
        }



    }






    private void Start()
    {


    }

}
