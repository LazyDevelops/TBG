using UnityEngine;
using UnityEngine.Tilemaps;

public class click : MonoBehaviour
{
    public Tilemap tilemap;           // 클릭할 타일맵
    public GameObject imageObject;    // 활성화할 UI 이미지 또는 패널

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // 좌클릭 감지
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int tilePos = tilemap.WorldToCell(mouseWorldPos);

            if (tilemap.HasTile(tilePos))  // 타일 존재 여부 체크
            {
                Debug.Log("Clicked tile at: " + tilePos);

                if (imageObject != null)
                {
                    imageObject.SetActive(true);  // UI 활성화
                }
            }
        }
    }
}