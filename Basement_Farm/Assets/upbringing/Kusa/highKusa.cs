using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highKusa : MonoBehaviour
{
    [SerializeField] private GameObject I;

    public static int high = 1;   //high�ϐ���錾

    public void Update()
    {
        if (GetGenerator.item03 >= 1)
        {
            I.SetActive(!false);
        }
        if (GetGenerator.item03 == 0)
        {
            I.SetActive(false);
        }
    }

    public void OnTouched()
    {
        high += 1;   //high�ϐ��𑝂₷

        GetGenerator.item03 -= 1;   //high�A�C�e�������炷

        Debug.Log("high��1�g����");
    }
}
