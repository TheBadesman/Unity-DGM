using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IDContainerBehaviour
{
  
    public ColorIDList colorIDListObj;

    private void Awake()
    {

        idObj = colorIDListObj.currentColor;

    }

    public void ChangeColor(SpriteRenderer renderer)
    {

        var newColor = idObj as ColorID;

        renderer.color = newColor.value;

    }

}
