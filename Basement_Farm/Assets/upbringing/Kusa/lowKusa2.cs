using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowKusa2 : MonoBehaviour
{
    [SerializeField] private GameObject I;

    public static int low = 1;   //low�ϐ���錾

    public void Update()
    {
        if (GetGenerator.item02 >= 1)
        {
            I.SetActive(!false);
        }
        if (GetGenerator.item02 == 0)
        {
            I.SetActive(false);
        }
    }

    public void OnTouched()
    {
        low += 1;   //low�ϐ��𑝂₷

        GetGenerator.item02 -= 1;     //low�A�C�e�������炷

        Debug.Log("low��1�g����");
    }
}
