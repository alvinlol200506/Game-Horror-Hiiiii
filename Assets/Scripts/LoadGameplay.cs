using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameplay : MonoBehaviour
{
    public TMP_Text loadingText;

    private IEnumerator Start()
    {
        loadingText.text = "Lagi loading nih!!";
        yield return new WaitForSeconds(1);
        loadingText.text = "sabar yaaaa!!";
        yield return new WaitForSeconds(1);
        loadingText.text = "almostttt!!";
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Game 1 scene");
    }
}
