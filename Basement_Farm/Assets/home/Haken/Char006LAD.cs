using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char006LAD : MonoBehaviour
{
    [SerializeField] private GameObject char006;

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
        if (chara3Selection.Chara3 >= 1)
        {
            if (rand < 50)
            {

                chara3Selection.Chara3 -= 1;

                Debug.Log("����");

                char006.SetActive(false);

            }
            else
            {

                Debug.Log("������");
                char006.SetActive(!false);


            }

        }
        else
        {
            char006.active = false;
        }
    }
}
