using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakuteriaevolution : MonoBehaviour
{
    [SerializeField] GameObject Bakuteria;

    [SerializeField] GameObject Kisei;

    [SerializeField] GameObject kurisutaru;



    public static int kisei = 0;    //����i���L�����P�̕ϐ��錾
    public static int bagu = 0;    //����i���L�����Q�̕ϐ��錾

    public int standard = 10;        //�i������A�C�e���̐�



    // Update is called once per frame
    public void Update()
    {

        //normalItem.
        if (normalBakuteria.normal >= standard)       //��萔normal�A�C�e����^���Đi������
        {
            Debug.Log("A�i�������I");

            Bakuteria.SetActive(false);

            GetGenerator.Chara9 -= 1;

            Kisei.SetActive(!false);

            kisei += 1;

            normalBakuteria.normal = 0;

        }
        //lowItem.
        if (rareBakuteria.rare >= standard)          //��萔low�A�C�e����^���Đi������
        {
            Debug.Log("B�i������!");

            Bakuteria.SetActive(false);

            GetGenerator.Chara9 -= 1;

            kurisutaru.SetActive(!false);

            bagu += 1;

            rareBakuteria.rare = 0;
        }

    }
}
