using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class SpriteBehavior : MonoBehaviour
{

    public SpriteRenderer rendererObj;

    public void OnEnable()
    {
        
        rendererObj = GetComponent<SpriteRenderer>();

    }

    public void ChangeRendererColor(ColorID obj)
    {

        rendererObj.color = obj.value;

    }

        public void ChangeRendererColor(ColorIDList obj)
    {

        rendererObj.color = obj.currentColor.value;

    }

}
