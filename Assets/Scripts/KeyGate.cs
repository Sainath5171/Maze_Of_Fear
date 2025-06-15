using UnityEngine;
using static KeyPickup;

public class Door : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "First Person Controller" && GameVariables.Keycount>0)
        {
            GameVariables.Keycount--;
            Destroy(gameObject);
        }
    }
}
