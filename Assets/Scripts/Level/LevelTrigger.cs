using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : LevelLoader
{
    [SerializeField] private string levelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadLevel(levelName);
        }
    }
}
