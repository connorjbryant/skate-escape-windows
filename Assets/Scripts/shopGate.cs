using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shopGate : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public GameObject popUp;

    public void DisableButton()
    {
        if (PermanentUI.perm.coins <= 0)
        {
            popUp.SetActive(true);
        }

        else
        {
            popUp.SetActive(false);
            SceneManager.LoadScene(sceneName);
        }

    }

    
}
