using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musiba3 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Musiba2Evolution.musi >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Musiba2Evolution.musi == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
