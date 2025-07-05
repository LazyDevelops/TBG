using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int playerGold = 100;
    public List<TileNode> tiles;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        InvokeRepeating(nameof(CollectResources), 1f, 3f); // 3�ʸ��� �ڿ� ����
    }

    void CollectResources()
    {
        foreach (var tile in tiles)
        {
            if (tile.owner == TileNode.Owner.Player)
            {
                playerGold += tile.GetProductionAmount();
            }
        }

        Debug.Log("Gold: " + playerGold);
    }

    public bool SpendGold(int amount)
    {
        if (playerGold >= amount)
        {
            playerGold -= amount;
            return true;
        }
        return false;
    }
}
