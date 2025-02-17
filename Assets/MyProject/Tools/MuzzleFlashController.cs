using UnityEngine;

public class MuzzleFlashController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ParticleSystem charge;

    private void Start()
    {
        charge.Stop();
    }
    public void Charge()
    {
        charge.Play();
    }

    public void ChargeStop()
    {
        charge.Stop();
    }
}
