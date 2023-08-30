using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char012LAD : MonoBehaviour
{
    [SerializeField] private GameObject char012;

    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 100);  //1~100の範囲
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        if (Chara012.CharCount012 >= 1)
        {
            if (rand < 50)
            {

                Kusa2evolution.kusa3 -= 1;

                Debug.Log("死ぬ");

                char012.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char012.SetActive(!false);


            }

        }
        else
        {
            char012.active = false;
        }
    }
}
