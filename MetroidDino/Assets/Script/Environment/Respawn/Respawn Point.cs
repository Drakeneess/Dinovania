using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    private RespawnCharacter respawn;
    private RespawnDetector respawnDetector;

    void Start()
    {
        respawn = FindObjectOfType<RespawnCharacter>();
        respawnDetector = GetComponentInChildren<RespawnDetector>();
        if (respawn == null)
        {
            Debug.LogError("RespawnCharacter not found in the scene!");
        }
    }
    void Update()
    {
        if (respawnDetector != null && respawnDetector.playerInArea)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                SetRespawnPoint();
            }
        }
    }
    // Método para establecer este punto como el punto de reaparición actual
    public void SetRespawnPoint()
    {
        if (respawn != null)
        {
            respawn.SetRespawnPoint(this);
            Debug.Log("Respawn point set to: " + transform.position);
        }
    }

    // Método para cargar la posición del punto de reaparición desde el SaveData
    public void LoadRespawnPoint()
    {
        if (respawn != null)
        {
            respawn.Respawn();
        }
    }
}
