
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
   public void PlayScene()
   {
       SceneManager.LoadScene("PlayScene");
   }
}
