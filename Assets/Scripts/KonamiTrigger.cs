using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KonamiTrigger : MonoBehaviour
{
    [SerializeField] private Konami konami;
    [SerializeField] private string konamiTag;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerCollider>() != null) {
            konamiTag = gameObject.tag;
            konami.OnKonamiTriggerEntered(konamiTag);
        }
    }
}
