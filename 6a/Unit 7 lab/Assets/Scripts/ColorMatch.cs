using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatch : MatchBehavior
{

    public ColorIDList colorIDListObj;

    private void Awake()
    {

        idObj = colorIDListObj.currentColor;

    }

}
