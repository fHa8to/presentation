using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kisei : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Bakuteriaevolution.kisei >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Bakuteriaevolution.kisei == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
