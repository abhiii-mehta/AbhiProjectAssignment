using UnityEngine;
using UnityEngine.UI;

public class CodexUIManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject codexPanel;
    public GameObject menuPage;
    public GameObject entryPage;
    public Button toggleButton;

    private bool isCodexOpen = false;

    void Start()
    {
        codexPanel.SetActive(false);
        toggleButton.onClick.AddListener(ToggleCodex);
    }

    void ToggleCodex()
    {
        isCodexOpen = !isCodexOpen;
        codexPanel.SetActive(isCodexOpen);

        if (isCodexOpen)
        {
            menuPage.SetActive(true);
            entryPage.SetActive(false);
        }
    }

    public void OpenEntryPage()
    {
        menuPage.SetActive(false);
        entryPage.SetActive(true);
    }

    public void BackToMenu()
    {
        entryPage.SetActive(false);
        menuPage.SetActive(true);
    }
}
