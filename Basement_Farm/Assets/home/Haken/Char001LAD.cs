using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char001LAD : MonoBehaviour
{
    [SerializeField] private GameObject char001;

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
        if(Char001.CharCount001 >= 1)
        {
            if (rand < 50)
            {

                chara1Selection.Chara1 -= 1;

                Debug.Log("死ぬ");

                char001.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char001.SetActive(!false);


            }

        }
        else
        {
            char001.active = false;
        }
    }
}
