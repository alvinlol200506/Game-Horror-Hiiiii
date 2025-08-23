using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TMP_Text GameOverText;
    public string gameOverMessage = "IHHHH TAKOTNYEEE";

    private IEnumerator Start()
    {
        GameOverText.gameObject.SetActive(true);
        GameOverText.text = gameOverMessage;

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
