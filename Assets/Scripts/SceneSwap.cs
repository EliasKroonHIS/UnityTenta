using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwap : MonoBehaviour
{
    public void MoveToScene(string sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
