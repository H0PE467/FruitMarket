using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana_Crates : MonoBehaviour, IInteractable
{


    void IInteractable.Interact(Transform interactorTransform)
    {
        Inventory_Manager.instance.addBanana();

    }

    string IInteractable.GetInteractText()
    {
        return "Banana";
    }

    Transform IInteractable.GetTransform()
    {
        return transform;
    }
}

