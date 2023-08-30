using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kabutoevolution : MonoBehaviour
{
    [SerializeField] GameObject Charakabuto;

    [SerializeField] GameObject Kurage;

    [SerializeField] GameObject Yadokari;



    public static int chara1to2 = 0;    //����i���L�����P�̕ϐ��錾
    public static int chara1to3 = 0;    //����i���L�����Q�̕ϐ��錾

    public int standard = 10;        //�i������A�C�e���̐�

   

    // Update is called once per frame
    public void Update()
    {
       
        //normalItem.
        if (normalItem.normal >= standard)       //��萔normal�A�C�e����^���Đi������
        {
            Debug.Log("A�i�������I");

            Charakabuto.SetActive(false);

            chara1Selection.Chara1 -= 1;

            Kurage.SetActive(!false);

            chara1to2 += 1;

            normalItem.normal = 0;

        }
        //lowItem.
        if (lowItem.low >= standard)          //��萔low�A�C�e����^���Đi������
        {
            Debug.Log("B�i������!");

            Charakabuto.SetActive(false);

            chara1Selection.Chara1 -= 1;

            Yadokari.SetActive(!false);

            chara1to3 += 1;

            lowItem.low = 0;
        }
        
    }
}
