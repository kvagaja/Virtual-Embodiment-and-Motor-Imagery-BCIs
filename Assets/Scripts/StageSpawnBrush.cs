using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using QuickVR;

public class StageSpawnBrush : QuickStageBase
{
    public GameObject prefab;
    public Transform parent;

    protected override IEnumerator CoUpdate()
    {
        yield return new WaitForSeconds(3);

        Instantiate(prefab, parent);

    }


}





