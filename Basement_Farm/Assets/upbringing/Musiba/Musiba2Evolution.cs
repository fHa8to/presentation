using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musiba2Evolution : MonoBehaviour
{
    [SerializeField] GameObject Musiba;

    [SerializeField] GameObject Musiba2;

    public static int musi;

    public int standard = 10;

    public void Update()
    {
        if (rareMusiba2.rare >= standard)       //��萔normal�A�C�e����^���Đi������
        {
            Debug.Log("�i�������I");

            Musiba.SetActive(false);

            Musibaevolution.musiba2 -= 1;

            Musiba2.SetActive(!false);

            musi += 1;

            rareMusiba2.rare = 0;

        }
    }
}
