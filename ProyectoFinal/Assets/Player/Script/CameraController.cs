using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;

    void Start()
    {
        UpdateCameraTarget();
    }

    public void UpdateCameraTarget()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            virtualCamera.Follow = player.transform;
            virtualCamera.LookAt = player.transform; // opcional, si quieres que también mire al jugador
        }
    }
}
