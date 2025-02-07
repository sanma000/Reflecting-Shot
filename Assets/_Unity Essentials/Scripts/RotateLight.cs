using UnityEngine;

public class RotateLight : MonoBehaviour
{
    // インスペクターで編集可能な変数
    public float dayDuration = 120.0f; // 1日の長さ（秒）

    // Updateは毎フレーム呼び出されます
    void Update()
    {
        // 1フレームごとに回転させる角度を計算
        float rotationAngle = (360.0f / dayDuration) * Time.deltaTime;
        transform.Rotate(Vector3.right, rotationAngle);
    }
}