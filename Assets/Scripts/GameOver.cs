using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string saveKey = "IsJumpscareKey";
    public Transform jumpScareCheckPoint;
    public Transform player;
    public TMP_Text GameOverText;
    public string gameOverMessage = "IHHHH TAKOTNYEEE";

    [Header("Debug")]
    public int isJumpscareSaved = 0;

    private void Awake()
    {
        isJumpscareSaved = PlayerPrefs.GetInt(saveKey);

        if (isJumpscareSaved == 1)
        {
            player.position = jumpScareCheckPoint.position;
            player.rotation = jumpScareCheckPoint.rotation;
        }
    }
    public void StartJumpscare()
    {
        StartCoroutine(StartJumpscareDelay());
    }
    IEnumerator StartJumpscareDelay()
    {
        GameOverText.gameObject.SetActive(true);
        GameOverText.text = gameOverMessage;

        isJumpscareSaved = 1;
        PlayerPrefs.SetInt(saveKey, isJumpscareSaved);
        PlayerPrefs.Save();

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
