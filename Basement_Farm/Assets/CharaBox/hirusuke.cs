using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hirusuke : MonoBehaviour
{
    public static int Chara4 = 0;

    [SerializeField] private GameObject a;


    public void Update()
    {

        if (Chara4 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (Chara4 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }


    }
}
