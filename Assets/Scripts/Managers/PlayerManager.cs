using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManager : MonoBehaviour
{
    PhotonView PV;
    GameObject controller;

    void Awake()
    {
        PV = GetComponent<PhotonView>();
    }

    private void Start()
    {
        if(PV.IsMine) 
        {
            CreateController();
        }
    }

    void CreateController() 
    {
        Debug.Log("Instantiated Player controller");
        Transform spawnPoint = SpawnManager.instance.GetSpawnPoint();
        controller = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Player"), spawnPoint.position, spawnPoint.rotation,0,new object[] {PV.ViewID});
    }

    public void Die()
    {
        PhotonNetwork.Destroy(controller);
        CreateController();
    }
}
