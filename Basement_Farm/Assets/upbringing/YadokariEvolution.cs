using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YadokariEvolution : MonoBehaviour
{
    [SerializeField] GameObject Yadokari;

    [SerializeField] GameObject Kani;

    public static int chara1to3to1 = 0;    //�i���L����1�̕ϐ��錾

    public int standard = 10;        //�i������A�C�e���̐�

    public void Update()
    {
        if(highYadokari.high >= standard)
        {
            Debug.Log("�i�������I");

            Yadokari.SetActive(false);

            kabutoevolution.chara1to3 -= 1;

            Kani.SetActive(!false);

            chara1to3to1 += 1;

            highYadokari.high = 0;
        }
    }
}
