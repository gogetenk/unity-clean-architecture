using UnityEngine;

namespace Controllers
{
    /// <summary>
    /// Sera adhérent à Unity et donc au MonoBehaviour car il va avoir toutes les liaisons avec les game objects etc...
    /// </summary>
    public class MyCharacterController : MonoBehaviour
    {
        public GameObject CharacterObject { get; set; }
    }
}
