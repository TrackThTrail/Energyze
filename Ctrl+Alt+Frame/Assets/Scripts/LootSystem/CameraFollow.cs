using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Refer�ncia ao transform do jogador
    public Transform player;

    // Posi��o de offset da c�mera em rela��o ao jogador
    public Vector3 offset;

    void Start()
    {
        // Calcula e armazena o offset inicial entre a c�mera e o jogador
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // Define a posi��o da c�mera baseada na posi��o do jogador e no offset
        transform.position = player.position + offset;
    }
}
