using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        //Play Attack Animation

        //Detect Enemy in Attack Radius
        //Damage Enemy

    }
}
