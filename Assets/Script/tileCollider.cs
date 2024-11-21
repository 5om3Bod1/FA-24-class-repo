using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class tileCollider : MonoBehaviour
{
    private TilemapRenderer tileMap;
    private void Awake()
    {
        tileMap = GetComponent<TilemapRenderer>();
    }
    private void Start()
    {
        tileMap.enabled = false;
    }
}
