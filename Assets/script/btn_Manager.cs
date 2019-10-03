
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_Manager : MonoBehaviour {

	public void LoadScene(string scenename)
    {
        SceneManager.LoadScene (scenename);
    }
}
