using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapes_Crate : MonoBehaviour, IInteractable
{
    void IInteractable.Interact(Transform interactorTransform)
    {
        Inventory_Manager.instance.addGrape();
    }

    string IInteractable.GetInteractText()
    {
        return "Uva";
    }

    Transform IInteractable.GetTransform()
    {
        return transform;
    }
}
