using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float minXClamp = 0.1f;
    public float maxXClamp = 101.3f;

    public float minYClamp = -0.79f;
    public float maxYClamp = 1.52f;

    //this fx always runs after fixed update - unity specifies this si where camera movement should happen
    private void LateUpdate()
    {
        Vector3 cameraPos = transform.position;

        cameraPos.x = Mathf.Clamp(player.transform.position.x, minXClamp, maxXClamp);
        cameraPos.y = Mathf.Clamp(player.transform.position.y, minYClamp, maxYClamp);

        transform.position = cameraPos;
    }
}
