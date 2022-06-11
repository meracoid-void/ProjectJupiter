using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;

    [SerializeField]
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.transform.position = player.transform.position;
        mainCamera.transform.Translate(0, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
