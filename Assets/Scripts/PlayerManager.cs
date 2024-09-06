using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Cinemachine;

public class PlayerManager : MonoBehaviour
{
    private StarterAssetsInputs input;

    [Header("Aim")]
    [SerializeField]
    private CinemachineVirtualCamera aimCam;
    
    [SerializeField]
    private gameObject crosshair;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if(input.aim)
        {
            aimCam.gameObject.SetActive(true);
            crosshair.gameObject.SetActive(true);
        }

        else
        {
            aimCam.gameObject.SetActive(false);
            crosshair.gameObject.SetActive(false);
        }
    }
}
