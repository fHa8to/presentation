using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara009 : MonoBehaviour
{
    public static int CharCount009 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char009;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Eye2Evolution.ai >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char009.SetActive(!false);

        }
        if (Eye2Evolution.ai == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char009.SetActive(false);
        }
    }
}
