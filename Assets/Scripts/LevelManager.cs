using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject playerPrefab;
    public Transform instantiatePos;
    public CameraMooving cameraMooving;
    public GameObject go;
    void Start()
    {
     go = Instantiate(playerPrefab, instantiatePos.position, Quaternion.identity);

        cameraMooving.target = go.transform;
    }

}
