using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaeru : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hanaevolution.ka >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Hanaevolution.ka == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }

    }
}
