using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour, IInteractable
{

    void IInteractable.Interact(Transform interactorTransform)
    {
        if (Inventory_Manager.instance.giveFruits(2,2,0,0,0,0))
        {
            Debug.Log("Pagado!");
            Score_Manager.instance.AddPoints(500);
        }
        else
        {
            Inventory_Manager.instance.emptyInventory();
            Debug.Log("Pedido Incorrecto");
            Score_Manager.instance.AddPoints(-300);

        }
    }

    string IInteractable.GetInteractText()
    {
        return "Interacting with Computer";
    }

    Transform IInteractable.GetTransform()
    {
        return transform;
    }
}
