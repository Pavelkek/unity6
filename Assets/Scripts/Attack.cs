using UnityEngine;

public class Attack : MonoBehaviour
{
   private static readonly int IsDead = Animator.StringToHash("isDead");

   private void OnCollisionEnter(Collision collision)
   {
      collision.gameObject.transform.parent.gameObject.GetComponent<Animator>().SetTrigger(IsDead);
   }
}
