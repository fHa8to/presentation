using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hana2 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hanaevolution.hana2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Hanaevolution.hana2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }

    }
}
