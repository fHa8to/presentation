using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hana3 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hana2evolution.hana3 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Hana2evolution.hana3 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }

    }
}
