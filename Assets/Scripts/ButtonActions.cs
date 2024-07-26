using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
    private NetworkManager networkManager;
    public TextMeshProUGUI text;

    void Start()
    {
        networkManager = GetComponentInParent<Unity.Netcode.NetworkManager>();
        if (networkManager == null)
        {
            Debug.LogError("NetworkManager component not found in parent objects.");
        }
    }

    public void StartHost()
    {
        if (networkManager != null)
        {
            networkManager.StartHost();
            InitMovementText();
        }
        else
        {
            Debug.LogError("NetworkManager is null, cannot start host.");
        }
    }

    public void StartClient()
    {
        if (networkManager != null)
        {
            networkManager.StartClient();
            InitMovementText();
        }
        else
        {
            Debug.LogError("NetworkManager is null, cannot start client.");
        }
    }

    private void InitMovementText()
    {
        if (NetworkManager.Singleton.IsServer)
        {
            text.text = "Request Move";
        }
    }
}