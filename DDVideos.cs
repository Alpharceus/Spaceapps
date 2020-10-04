using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDVideos : MonoBehaviour
{
    
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            SceneManager.LoadScene("Videos");
        }
        if (val == 1)
        {
            SceneManager.LoadScene("O3Video");
        }
        if (val == 2)
        {
            SceneManager.LoadScene("ADVideo");
        }
    }
   

}
