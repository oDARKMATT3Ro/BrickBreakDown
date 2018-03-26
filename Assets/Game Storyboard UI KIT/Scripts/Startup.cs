using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Startup : MonoBehaviour {

    public float waitTime = 3.0f;

    private IEnumerator LogoFinishEvent() {

        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(1);

    }

}
