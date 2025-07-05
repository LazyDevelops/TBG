using System.Diagnostics;
using UnityEngine;

[RequireComponent(typeof(TileNode))]
public class TileClickHandler : MonoBehaviour
{
    private TileNode tile;

    private void Start()
    {
        tile = GetComponent<TileNode>();
    }

    private void OnMouseDown()
    {
        if (tile.owner == TileNode.Owner.None)
        {
            tile.Occupy(TileNode.Owner.Player);
        }
        else if (tile.owner == TileNode.Owner.Player)
        {
            int upgradeCost = 50 + tile.level * 50;

            if (GameManager.Instance.SpendGold(upgradeCost))
            {
                tile.Upgrade();
            }
            else
            {
                Debug.Log("∞ÒµÂ ∫Œ¡∑!");
            }
        }
    }
}
