using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusa3 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Kusa2evolution.kusa3 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Kusa2evolution.kusa3 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
