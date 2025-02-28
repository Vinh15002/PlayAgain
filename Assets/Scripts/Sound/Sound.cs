using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioSource m_Source;

    private void Start()
    {
        m_Source = GetComponent<AudioSource>();
    }



    public AudioSource GetSound()
    {
        return m_Source;
    }
}