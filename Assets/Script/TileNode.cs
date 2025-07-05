using UnityEngine;

public class TileNode : MonoBehaviour
{
    public enum Owner { None, Player, Enemy }

    public Owner owner = Owner.None;
    public int level = 0; // ��ȭ �ܰ�
    public int baseProduction = 10; // �⺻ �ڿ� ���귮

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
        // ����: ���� ����
        var sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            if (owner == Owner.Player) sr.color = Color.blue;
            else if (owner == Owner.Enemy) sr.color = Color.red;
            else sr.color = Color.gray;
        }
    }
}
