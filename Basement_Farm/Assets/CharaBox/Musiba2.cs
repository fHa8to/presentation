using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musiba2 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Musibaevolution.musiba2 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Musibaevolution.musiba2 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
