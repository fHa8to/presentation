using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiba : MonoBehaviour
{
    public static int Chara6 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara6 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Chara6 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }


    }
}
