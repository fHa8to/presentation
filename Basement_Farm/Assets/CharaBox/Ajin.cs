using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ajin : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Tukievolution.ajin >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Tukievolution.ajin == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }

    }
}
