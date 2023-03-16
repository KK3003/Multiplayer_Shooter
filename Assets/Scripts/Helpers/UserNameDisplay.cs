using Photon.Pun;
using TMPro;
using UnityEngine;

public class UserNameDisplay : MonoBehaviour
{

    [SerializeField] PhotonView playerPV;
    [SerializeField] TMP_Text text;

    void Start()
    {
        if(playerPV.IsMine)
        {
            gameObject.SetActive(false);
        }

        text.text = playerPV.Owner.NickName;
    }
}
