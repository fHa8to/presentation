using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rareMusiba2 : MonoBehaviour
{
    [SerializeField] private GameObject I;

    public static int rare = 1;    //rare�ϐ���錾

    public void Update()
    {
        if (GetGenerator.item04 >= 1)
        {
            I.SetActive(!false);
        }
        if (GetGenerator.item04 == 0)
        {
            I.SetActive(false);
        }
    }

    public void OnTouched()
    {
        rare += 1;  //rare�ϐ��𑝂₷

        GetGenerator.item04 -= 1;    //rare�A�C�e�����炷

        Debug.Log("rare��1�g����");
    }
}
