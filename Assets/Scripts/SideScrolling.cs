using UnityEngine;

public class SideScrolling : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 cameraPostion = transform.position;
        cameraPostion.x = Mathf.Max(cameraPostion.x, player.position.x);
        transform.position = cameraPostion;
    }
}
