using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hirunanndesu : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Hirusukeevolution.hirunann >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            a.SetActive(!false);

        }
        if (Hirusukeevolution.hirunann == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            a.SetActive(false);
        }

    }
}
