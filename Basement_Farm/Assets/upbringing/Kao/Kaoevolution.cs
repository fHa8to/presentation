using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaoevolution : MonoBehaviour
{
    [SerializeField] GameObject Kao;

    [SerializeField] GameObject Kao2;

    public static int kao2;

    public int standard = 10;

    public void Update()
    {
        if (lowKao.low >= standard)       //��萔normal�A�C�e����^���Đi������
        {
            Debug.Log("�i�������I");

            Kao.SetActive(false);

            kao.Chara5 -= 1;

            Kao2.SetActive(!false);

            kao2 += 1;

            lowKao.low = 0;

        }
    }
}
