using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char023LAD : MonoBehaviour
{
    [SerializeField] private GameObject char023;

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
        if (Chara023.CharCount023 >= 1)
        {
            if (rand < 50)
            {

                kusa.Chara7 -= 1;

                Debug.Log("死ぬ");

                char023.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char023.SetActive(!false);


            }

        }
        else
        {
            char023.active = false;
        }
    }
}
