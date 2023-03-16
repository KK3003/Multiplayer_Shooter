using Photon.Pun;
using TMPro;
using UnityEngine;

public class PlayerNameManager : MonoBehaviour
{
    [SerializeField] TMP_InputField userNameInput;
    private void Start()
    {
        if(PlayerPrefs.HasKey("username"))
        {
            userNameInput.text = PlayerPrefs.GetString("username");
            PhotonNetwork.NickName = PlayerPrefs.GetString("username");
        }
        else
        {
            userNameInput.text = "Player" + Random.Range(0, 10000).ToString("0000");
            OnUserNameChnaged();
        }
    }
    public void OnUserNameChnaged()
    {
        PhotonNetwork.NickName = userNameInput.text;    
        PlayerPrefs.SetString("username", userNameInput.text);
    }
}
  