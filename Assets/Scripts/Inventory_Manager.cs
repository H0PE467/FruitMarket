using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory_Manager : MonoBehaviour
{
    [SerializeField] private GameObject grape_Inventory;
    [SerializeField] private TextMeshProUGUI grape_Counter;
    int grapes_in_inventory = 0;

    [SerializeField] private GameObject apple_Inventory;
    [SerializeField] private TextMeshProUGUI apple_Counter;
    int apples_in_inventory = 0;

    [SerializeField] private GameObject orange_Inventory;
    [SerializeField] private TextMeshProUGUI orange_Counter;
    int oranges_in_inventory = 0;

    [SerializeField] private GameObject pear_Inventory;
    [SerializeField] private TextMeshProUGUI pear_Counter;
    int pears_in_inventory = 0;

    [SerializeField] private GameObject watermelon_Inventory;
    [SerializeField] private TextMeshProUGUI watermelon_Counter;
    int watermelons_in_inventory = 0;

    [SerializeField] private GameObject banana_Inventory;
    [SerializeField] private TextMeshProUGUI banana_Counter;
    int bananas_in_inventory = 0;



    public static Inventory_Manager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        hideApples();
        hideGrapes();
        hideOranges();
        hidePears();
        hideWatermelon();
        hideBananas();
    }

    public bool giveFruits(int grapes_to_give, int apples_to_give, int oranges_to_give, 
                            int pears_to_give, int pineapples_to_give, int bananas_to_give)
    {
        if (grapes_in_inventory != grapes_to_give)
        {
            return false;
        }
        if (apples_in_inventory != apples_to_give)
        {
            return false;
        }
        if (oranges_in_inventory != oranges_to_give)
        {
            return false;
        }
        if (pears_in_inventory != pears_to_give)
        {
            return false;
        }
        if (watermelons_in_inventory != pineapples_to_give)
        {
            return false;
        }
        if (bananas_in_inventory != bananas_to_give)
        {
            return false;
        }

        grapes_in_inventory = grapes_in_inventory - grapes_to_give;
        hideGrapes();
        apples_in_inventory = apples_in_inventory  - apples_to_give;
        hideApples();
        oranges_in_inventory = oranges_in_inventory - oranges_to_give;
        hideOranges();
        pears_in_inventory = pears_in_inventory - pears_to_give;
        hidePears();
        watermelons_in_inventory = watermelons_in_inventory - pineapples_to_give;
        hideWatermelon();
        bananas_in_inventory = bananas_in_inventory - bananas_to_give;
        hideBananas();
        return true;

    }


    //
    //     ADDS
    //

    public void addGrape()
    {
        grape_Inventory.SetActive(true);
        grapes_in_inventory = grapes_in_inventory + 1;
        grape_Counter.text = grapes_in_inventory.ToString();
    }
    public void addApple()
    {
        apple_Inventory.SetActive(true);
        apples_in_inventory = apples_in_inventory + 1;
        apple_Counter.text = apples_in_inventory.ToString();
    }
    public void addOrange()
    {
        orange_Inventory.SetActive(true);
        oranges_in_inventory = oranges_in_inventory + 1;
        orange_Counter.text = oranges_in_inventory.ToString();
    }
    public void addPear()
    {
        pear_Inventory.SetActive(true);
        pears_in_inventory = pears_in_inventory + 1;
        pear_Counter.text = pears_in_inventory.ToString();
    }

    public void addWatermelon()
    {
        watermelon_Inventory.SetActive(true);
        watermelons_in_inventory = watermelons_in_inventory + 1;
        watermelon_Counter.text = watermelons_in_inventory.ToString();
    }
    public void addBanana()
    {
        banana_Inventory.SetActive(true);
        bananas_in_inventory = bananas_in_inventory + 1;
        banana_Counter.text = bananas_in_inventory.ToString();
    }

    //
    //     HIDES
    //

    private void hideGrapes()
    {
        if (grapes_in_inventory == 0)
        {
            grape_Inventory.SetActive(false);
        }
    }
    private void hideApples()
    {
        if (apples_in_inventory == 0)
        {
            apple_Inventory.SetActive(false);
        }
    }
    private void hideOranges()
    {
        if (oranges_in_inventory == 0)
        {
            orange_Inventory.SetActive(false);
        }
    }
    private void hidePears()
    {
        if (pears_in_inventory == 0)
        {
            pear_Inventory.SetActive(false);
        }
    }
    private void hideWatermelon()
    {
        if (watermelons_in_inventory == 0)
        {
            watermelon_Inventory.SetActive(false);
        }
    }
    private void hideBananas()
    {
        if (bananas_in_inventory == 0)
        {
            banana_Inventory.SetActive(false);
        }
    }

    //
    //  EMPTYING INVENTORY
    //

    public void emptyInventory()
    {
        grapes_in_inventory = 0;
        apples_in_inventory = 0;
        oranges_in_inventory = 0;
        pears_in_inventory = 0;
        watermelons_in_inventory = 0;
        bananas_in_inventory = 0;


        hideApples();
        hideGrapes();
        hideOranges();
        hidePears();
        hideWatermelon();
        hideBananas();
    }
}
