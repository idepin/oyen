using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] private Image itemImage;

    public void UpdateUI(Item item)
    {
        itemImage.sprite = item.itemIcon;
    }
}
