using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kao : MonoBehaviour
{
    public static int Chara5 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara5 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Chara5 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
