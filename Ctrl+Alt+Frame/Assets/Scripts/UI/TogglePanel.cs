using UnityEngine;

public class TogglePanel : MonoBehaviour
{
    // Refer�ncia ao GameObject que queremos abrir/fechar
    public GameObject panel;

    private void Start()
    {
        panel.SetActive(false);
    }
    void Update()
    {
        // Verifica se a tecla P foi pressionada
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Se o painel est� ativo, desativa. Se est� desativado, ativa.
            panel.SetActive(!panel.activeSelf);
        }
        // Verifica se a tecla Esc foi pressionada e o painel est� ativo
        else if (Input.GetKeyDown(KeyCode.Escape) && panel.activeSelf)
        {
            // Desativa o painel
            panel.SetActive(false);
        }
    }
}
