using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faceevolution : MonoBehaviour
{
    [SerializeField] GameObject Face;

    [SerializeField] GameObject Face1;

    public static int face;

    public int standard = 10;
    public void Update()
    {
        if (lowFace.low >= standard)       //��萔normal�A�C�e����^���Đi������
        {
            Debug.Log("�i�������I");

            Face.SetActive(false);

            Kaoevolution.kao2 -= 1;

            Face1.SetActive(!false);

            face += 1;

            lowFace.low = 0;

        }
    }
}
