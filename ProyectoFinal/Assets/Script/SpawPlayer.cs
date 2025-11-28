using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawPlayer : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    public CameraController cameraController;
    [SerializeField] private Transform[] _SpawPoint;
    private int index = 0;

    public int Index { get => index; set => index = value; }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Player") == null)
        {
            SpawJugador();
            Debug.Log("Jugador respawneado");
        }
    }


    public void SpawJugador()
    {
        GameObject newPlayer = Instantiate(playerPrefab, _SpawPoint[index].transform.position, Quaternion.identity);
        StartCoroutine(ActualizarCamaraDespuesDeSpawn());
    }

    private IEnumerator ActualizarCamaraDespuesDeSpawn()
    {
        yield return new WaitForEndOfFrame();
        cameraController.UpdateCameraTarget();
    }


}