using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private float smoothing;

    [SerializeField] private Vector2 maxPos;
    [SerializeField] private Vector2 minPos;

    private void FixedUpdate()
    {
        if(transform.position != player.position)
        {
            Vector3 targetPos = new Vector3(player.position.x, player.position.y, transform.position.z);

            targetPos.x = Mathf.Clamp(targetPos.x, minPos.x, maxPos.x);
            targetPos.y = Mathf.Clamp(targetPos.y, minPos.x, maxPos.y);

            transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        }
    }
}
