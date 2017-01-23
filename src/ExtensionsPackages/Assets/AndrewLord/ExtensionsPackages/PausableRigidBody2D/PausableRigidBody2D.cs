namespace AndrewLord.ExtensionsPackages.UnityPausableRigidBody2D {

  using UnityEngine;

  /// <summary>
  /// Allows you to pause and resume the RigidBody2D that is attached to the same GameObject.
  /// </summary>
  public class PausableRigidBody2D : MonoBehaviour {

    private Rigidbody2D body;
    private Vector3 savedVelocity;
    private float savedAngularVelocity;

    void Awake() {
      body = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Pause the RigidBody2D, saving its current velocity and angular velocity.
    /// </summary>
    public void Pause() {
      savedVelocity = body.velocity;
      savedAngularVelocity = body.angularVelocity;
      body.velocity = Vector3.zero;
      body.angularVelocity = 0f;
      body.isKinematic = true;
    }

    /// <summary>
    /// Resume the RigidBody2D, restoring its velocity and angular velocity to that of before it was paused.
    /// </summary>
    public void Resume() {
      body.isKinematic = false;
      body.velocity = savedVelocity;
      body.angularVelocity = savedAngularVelocity;
      body.WakeUp();
    }

    /// <summary>
    /// Re-enable physics on the RigidBody2D, without any velocities being restored.
    /// </summary>
    public void Reactivate() {
      body.isKinematic = false;
      body.WakeUp();
    }
  }
}
