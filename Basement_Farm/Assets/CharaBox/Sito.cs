using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sito : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (TaijiEvolution.sito >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (TaijiEvolution.sito == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }

    }
}
