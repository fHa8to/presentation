using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char024LAD : MonoBehaviour
{
    [SerializeField] private GameObject char024;

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
        if (Musibaevolution.musiba2 >= 1)
        {
            if (rand < 50)
            {

                Musibaevolution.musiba2 -= 1;

                Debug.Log("����");

                char024.SetActive(false);

            }
            else
            {

                Debug.Log("������");
                char024.SetActive(!false);


            }

        }
        else
        {
            char024.active = false;
        }
    }
}
