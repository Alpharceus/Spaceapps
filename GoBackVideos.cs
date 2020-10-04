using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoBackVideos : MonoBehaviour
{
    public void gotovideos()
    {
        SceneManager.LoadScene("Videos");
    }

}
