using UnityEngine;

public class gamestrat : MonoBehaviour
{
    public GameObject myCanvas; // Inspector에서 캔버스 게임 오브젝트를 할당합니다.
    public KeyCode toggleKey = KeyCode.Space; // 활성화/비활성화에 사용할 키를 설정합니다.

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            myCanvas.SetActive(!myCanvas.activeSelf); // 캔버스의 현재 활성화 상태를 반전시킵니다.
        }
    }
}