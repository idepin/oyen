using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] ItemUI itemUIPrefab;
    [SerializeField] private GameObject itemContainer;

    public void AddItemUI(Item item)
    {
        ItemUI itemUI = Instantiate(itemUIPrefab, itemContainer.transform);
        itemUI.UpdateUI(item);
    }
}
