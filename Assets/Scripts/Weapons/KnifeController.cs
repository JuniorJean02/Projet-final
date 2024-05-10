using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : WeaponController
{
    // Start is called before the first frame update
   protected override void Start()
    {
        base.Start();
    }


    protected override void Attack()
    {
        base.Attack();
        GameObject spawendKnife = Instantiate(weaponData.Prefab);
        spawendKnife.transform.position = transform.position;
        spawendKnife.GetComponent<KnifeBehaviour>().Directioncheker(pm.lastMovedVector);

    }
}
