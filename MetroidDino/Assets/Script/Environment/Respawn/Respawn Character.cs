using System.Collections;
using UnityEngine;

public class RespawnCharacter : MonoBehaviour
{
    public float respawnDelay = 2f;
    public RespawnPoint respawnPoint;

    // Método para establecer el punto de reaparición
    public void SetRespawnPoint(RespawnPoint respawn)
    {
        respawnPoint = respawn;
    }

    // Método para iniciar la reaparición después de un retraso
    public void Respawn()
    {
        StartCoroutine(RespawnCoroutine());
    }

    private IEnumerator RespawnCoroutine()
    {
        // Esperar el tiempo de retraso antes de reaparecer
        yield return new WaitForSeconds(respawnDelay);
        Vector3 point=new Vector3(respawnPoint.transform.position.x,0f,0f);
        transform.position = point;
        // Aquí podrías agregar más lógica, como restablecer la salud del jugador, reproducir animaciones, etc.
    }
}
