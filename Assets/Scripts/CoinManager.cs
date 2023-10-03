using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private int coinCount = 1;
    [SerializeField] private float minXPosition = -8f;
    [SerializeField] private float maxXPosition = 8f;

    private void Start()
    {
        Generate();
    }

    private void Generate()
    {
        for (int i = 0; i < coinCount; i++)
        {
            GameObject instantiatedCoin = Instantiate(coin, transform);
            instantiatedCoin.transform.Translate(new Vector3(Random.Range(minXPosition, maxXPosition), 0, 0));
        }
    }

}
