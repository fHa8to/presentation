using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaijiEvolution : MonoBehaviour
{
    [SerializeField] GameObject Taiji;

    [SerializeField] GameObject Sito;

    [SerializeField] GameObject Tuki;



    public static int sito = 0;    //����i���L�����P�̕ϐ��錾
    public static int tuki = 0;    //����i���L�����Q�̕ϐ��錾

    public int standard = 10;        //�i������A�C�e���̐�



    // Update is called once per frame
    public void Update()
    {

        //normalItem.
        if (normalTaiji.normal >= standard)       //��萔normal�A�C�e����^���Đi������
        {
            Debug.Log("A�i�������I");

            Taiji.SetActive(false);

            taiji.Chara8 -= 1;

            Sito.SetActive(!false);

            sito += 1;

            normalTaiji.normal = 0;

        }
        //lowItem.
        if (highTaiji.high >= standard)          //��萔low�A�C�e����^���Đi������
        {
            Debug.Log("B�i������!");

            Taiji.SetActive(false);

            taiji.Chara8 -= 1;

            Tuki.SetActive(!false);

            tuki += 1;

            highTaiji.high = 0;
        }

    }
}
