using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara026 : MonoBehaviour
{
    public static int CharCount026 = 0;     //�Q�b�g�V�[���̕ϐ��錾

    [SerializeField] private GameObject char026;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Musiba2Evolution.musi >= 1) //Chara1��1�ȏゾ�����ꍇ�\��
        {

            char026.SetActive(!false);

        }
        if (Musiba2Evolution.musi == 0) //Chara1��1�ȉ��������ꍇ��\��
        {
            char026.SetActive(false);
        }
    }
}
