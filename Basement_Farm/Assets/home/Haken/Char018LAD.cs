using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char018LAD : MonoBehaviour
{
    [SerializeField] private GameObject char018;

    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 100);  //1~100�͈̔�
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        if (Chara018.CharCount018 >= 1)
        {
            if (rand < 50)
            {

                Hana2evolution.hana3 -= 1;

                Debug.Log("����");

                char018.SetActive(false);

            }
            else
            {

                Debug.Log("������");
                char018.SetActive(!false);


            }

        }
        else
        {
            char018.active = false;
        }
    }
}
