using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{
    public TMP_Text deathText;
    public string deathMessage = "MATIIII!!!!";
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            deathText.gameObject.SetActive(true);
            deathText.text = deathMessage;

            StartCoroutine(RestartDelay());
        }
    }

    private IEnumerator RestartDelay()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
