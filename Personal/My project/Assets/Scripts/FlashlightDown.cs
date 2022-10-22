using UnityEngine;

public class FlashlightDown : MonoBehaviour
{

    private void Update() 
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {

            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;

        }

    }

}
