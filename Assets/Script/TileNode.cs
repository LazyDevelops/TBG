using UnityEngine;

public class TileNode : MonoBehaviour
{
    public enum Owner { None, Player, Enemy }

    public Owner owner = Owner.None;
    public int level = 0; // 강화 단계
    public int baseProduction = 10; // 기본 자원 생산량

    public bool IsOwned => owner != Owner.None;

    public int GetProductionAmount()
    {
        return baseProduction * (level + 1);
    }

    public void Occupy(Owner newOwner)
    {
        owner = newOwner;
        level = 0;
        UpdateVisuals();
    }

    public void Upgrade()
    {
        if (owner == Owner.Player)
        {
            level++;
            UpdateVisuals();
        }
    }

    private void UpdateVisuals()
    {
        // 예시: 색상 변경
        var sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            if (owner == Owner.Player) sr.color = Color.blue;
            else if (owner == Owner.Enemy) sr.color = Color.red;
            else sr.color = Color.gray;
        }
    }
}
