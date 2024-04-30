using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BuyButtons : MonoBehaviour
{
    public static BuyButtons instance;

    public int money;
    public Text moneyText;
    public bool Gear1 = false;
    public Text gear1Text;
    public bool Gear2 = false;
    public Text gear2Text;
    public bool Gear3 = false;
    public Text gear3Text;
    public bool Launcher1 = false;
    public bool L1Bought = false;
    public Text launcher1Text;
    public bool Launcher2 = false;
    public bool L2Bought = false;
    public Text launcher2Text;
    public bool Launcher3 = false;
    public bool L3Bought = false;
    public Text launcher3Text;

    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        moneyText.text = "$ " + money.ToString("");
    }

    public void Gear1Upgrade() 
    {
        if (money >= 400 && !Gear1)
        {
            money -= 400;
            Debug.Log("This shows that the First Gear Upgrade has been purchased");
            Gear1 = true;
            gear1Text.text = "Equipped";
            if (Gear2)
            {
                gear2Text.text = "Equip";
            }
            if (Gear3)
            {
                gear3Text.text = "Equip";
            }
        }
        else if (Gear1)
        {
            gear1Text.text = "Equipped";
            if (Gear2)
            {
                gear2Text.text = "Equip";
            }
            if (Gear3)
            {
                gear3Text.text = "Equip";
            }
        }
        moneyText.text = "$ " + money.ToString("");
    }
    public void Gear2Upgrade()
    {
        if (money >= 8000 && !Gear2)
        {
            money -= 8000;
            Debug.Log("This shows that the Second Gear Upgrade has been purchased");
            Gear2 = true;
            gear2Text.text = "Equipped";
            if (Gear1) 
            {
                gear1Text.text = "Equip";
            }
            if (Gear3) 
            {
                gear3Text.text = "Equip";
            }
        }
        else if (Gear2)
        {
            gear2Text.text = "Equipped";
            if (Gear1)
            {
                gear1Text.text = "Equip";
            }
            if (Gear3)
            {
                gear3Text.text = "Equip";
            }
        }
        moneyText.text = "$ " + money.ToString("");
    }
    public void Gear3Upgrade()
    {
        if (money >= 100000 && !Gear3)
        {
            money -= 100000;
            Debug.Log("This shows that the Third Gear Upgrade has been purchased");
            Gear3 = true;
            gear3Text.text = "Equipped";
            if (Gear1)
            {
                gear1Text.text = "Equip";
            }
            if (Gear2)
            {
                gear2Text.text = "Equip";
            }
        }
        else if (Gear3)
        {
            gear3Text.text = "Equipped";
            if (Gear2)
            {
                gear2Text.text = "Equip";
            }
            if (Gear1)
            {
                gear1Text.text = "Equip";
            }
        }
        moneyText.text = "$ " + money.ToString("");
    }
    public void Launcher1Upgrade()
    {
        if (L1Bought) 
        {
            Launcher1 = true; 
            launcher1Text.text = "Equipped";
            if (L2Bought)
            {
                launcher2Text.text = "Equip";
                Launcher2 = false;
            }
            if (L3Bought)
            {
                launcher3Text.text = "Equip";
                Launcher3 = false;
            }
        }
        else if (money >= 600 && !Launcher1)
        {
            money -= 600;
            Debug.Log("This shows that the First Launcher Upgrade has been purchased");
            Launcher1 = true;
            L1Bought = true;
            launcher1Text.text = "Equipped";
            if (L2Bought)
            {
                launcher2Text.text = "Equip";
            }
            if (L3Bought)
            {
                launcher3Text.text = "Equip";
            }
        }
        else if (Launcher1)
        {
            launcher1Text.text = "Equipped";
            if (L2Bought)
            {
                launcher2Text.text = "Equip";
            }
            if (L3Bought)
            {
                launcher3Text.text = "Equip";
            }
        }
        moneyText.text = "$ " + money.ToString("");
    }
    public void Launcher2Upgrade()
    {
        if (L2Bought)
        {            
            Launcher2 = true;
            launcher2Text.text = "Equipped";
            if (L1Bought)
            {
                launcher1Text.text = "Equip";
                Launcher1 = false;
            }
            if (L3Bought)
            {
                launcher3Text.text = "Equip";
                Launcher3 = false;
            }
        }
        else if (money >= 10000 && !Launcher2)
        {
            money -= 10000;
            Debug.Log("This shows that the Second Launcher Upgrade has been purchased");
            Launcher2 = true;
            L2Bought = true;
            launcher2Text.text = "Equipped";
            if (L1Bought)
            {
                launcher1Text.text = "Equip";
            }
            if (L3Bought)
            {
                launcher3Text.text = "Equip";
            }
        }
        else if (Launcher2)
        {
            launcher2Text.text = "Equipped";
            if (L1Bought)
            {
                launcher1Text.text = "Equip";
            }
            if (L3Bought)
            {
                launcher3Text.text = "Equip";
            }
        }
        moneyText.text = "$ " + money.ToString("");
    }
    public void Launcher3Upgrade()
    {
        if (L3Bought)
        {                     
            Launcher3 = true;
            launcher3Text.text = "Equipped";
            if (L1Bought)
            {
                launcher1Text.text = "Equip";
                Launcher1 = false;
            }
            if (L2Bought)
            {
                launcher2Text.text = "Equip";
                Launcher2 = false;
            }
        }
        else if (money >= 150000 && !Launcher3)
        {
            money -= 150000;
            Debug.Log("This shows that the Third Launcher Upgrade has been purchased");
            Launcher3 = true;
            L3Bought = true;
            launcher3Text.text = "Equipped";
            if (L2Bought)
            {
                launcher2Text.text = "Equip";
            }
            if (L1Bought)
            {
                launcher1Text.text = "Equip";
            }
        }
        else if (Launcher3)
        {
            launcher3Text.text = "Equipped";
            if (L2Bought)
            {
                launcher2Text.text = "Equip";
            }
            if (L1Bought)
            {
                launcher1Text.text = "Equip";
            }
        }
        moneyText.text = "$ " + money.ToString("");
    }
}
