using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabutoEvolution2 : MonoBehaviour
{
    [SerializeField] private GameObject a;


    public void Update()
    {

        if (kabutoevolution.chara1to3 >= 1) //Chara1が1以上だった場合表示
        {

            a.SetActive(!false);

        }
        if (kabutoevolution.chara1to3 == 0) //Chara1が1以下だった場合非表示
        {
            a.SetActive(false);
        }

    }
}
