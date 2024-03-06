using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackSettings : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
