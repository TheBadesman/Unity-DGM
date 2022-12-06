using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatch : MatchBehavior
{

    public ColorIDList colorIDListObj;

    public void Awake()
    {

        idObj = colorIDListObj.currentColor;

    }

}
