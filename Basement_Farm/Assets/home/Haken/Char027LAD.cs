using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char027LAD : MonoBehaviour
{
    [SerializeField] private GameObject char027;

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
        if (Chara027.CharCount027 >= 1)
        {
            if (rand < 50)
            {

                taiji.Chara8 -= 1;

                Debug.Log("死ぬ");

                char027.SetActive(false);

            }
            else
            {

                Debug.Log("生きる");
                char027.SetActive(!false);


            }

        }
        else
        {
            char027.active = false;
        }
    }
}
