using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kani : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (YadokariEvolution.chara1to3to1 >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (YadokariEvolution.chara1to3to1 == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }

    }
}
