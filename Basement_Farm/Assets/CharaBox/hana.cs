using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hana : MonoBehaviour
{
    [SerializeField] private GameObject c ;

    void Update()
    {

        if (chara3Selection.Chara3 >= 1) //Chara1が1以上だった場合表示
        {

            c.SetActive(!false);

        }
        if (chara3Selection.Chara3 == 0) //Chara1が1以下だった場合非表示
        {
            c.SetActive(false);
        }


    }
}
