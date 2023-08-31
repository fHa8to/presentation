using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class eye : MonoBehaviour
{

    [SerializeField] private GameObject b ;

    public void Update()
    {

        if (chara2Selection.Chara2 >= 1) //Chara1‚ª1ˆÈã‚¾‚Á‚½ê‡•\¦
        {

            b.SetActive(!false);

        }
        if (chara2Selection.Chara2 == 0) //Chara1‚ª1ˆÈ‰º‚¾‚Á‚½ê‡”ñ•\¦
        {
            b.SetActive(false);
        }


    }
}
