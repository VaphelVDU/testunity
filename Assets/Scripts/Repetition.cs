using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repetition : MonoBehaviour
{
    public float f;
    public int i;
    public double d;
    public string s;
    public bool doPrint;

    public string[] texter;
    public bool[,] bArr2;
    public float[][] fArr3;

    // Use this for initialization
    private void Start()
    {
        Story();
    }
    private void RepetitionsFunktionen()
    {
        //if for loop och while loop kallas man för kontroll strukturer
        if ((doPrint == true && i == 7) || f == 2.01f)
        {

            Debug.Log("I'm printing");
        }
        else
        {
            Debug.LogWarning("Oh noes.");
        }
    }
    public void Story()
    {
        for (int count = 0; count < texter.Length; count++)
        {
            Debug.Log(texter[count]);
        }
    }
    private void Update()
    {
    }
}
