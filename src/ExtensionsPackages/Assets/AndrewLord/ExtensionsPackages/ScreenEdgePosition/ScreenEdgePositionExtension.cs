namespace AndrewLord.ExtensionsPackages.UnityScreenEdgePosition {

  using UnityEngine;

  public enum ScreenEdge {
    Left, Right, Top, Bottom
  };

  public static class ScreenEdgePositionExtension {

    public static Transform SetX(this Transform transform, float x) {
      Vector3 position = transform.position;
      position.x = x;
      transform.position = position;
      return transform;
    }

    public static Transform SetY(this Transform transform, float y) {
      Vector3 position = transform.position;
      position.y = y;
      transform.position = position;
      return transform;
    }

    public static Transform SetPositionRelativeToScreenEdge(this Transform transform, ScreenEdge edge, float offset) {
      float edgePosition = CalculateEdgePosition(edge);
      switch (edge) {
        case ScreenEdge.Left:
          transform.SetX(edgePosition + offset);
          break;
        case ScreenEdge.Right:
          transform.SetX(edgePosition + offset);
          break;
        case ScreenEdge.Top:
          transform.SetY(edgePosition + offset);
          break;
        case ScreenEdge.Bottom:
          transform.SetY(edgePosition + offset);
          break;
      }
      return transform;
    }

    private static float CalculateEdgePosition(ScreenEdge edge) {
      Camera camera = Camera.main;
      switch (edge) {
        case ScreenEdge.Left:
          return camera.ScreenToWorldPoint(new Vector3(0, 0)).x;
        case ScreenEdge.Right:
          return camera.ScreenToWorldPoint(new Vector3(Screen.width, 0)).x;
        case ScreenEdge.Top:
          return camera.ScreenToWorldPoint(new Vector3(0, Screen.height)).y;
        case ScreenEdge.Bottom:
          return camera.ScreenToWorldPoint(new Vector3(0, 0)).y;
      }
      return 0f;
    }

    public static Transform SetLocalX(this Transform transform, float localX) {
      Vector3 localPosition = transform.localPosition;
      localPosition.x = localX;
      transform.localPosition = localPosition;
      return transform;
    }

    public static Transform SetLocalY(this Transform transform, float localY) {
      Vector3 localPosition = transform.localPosition;
      localPosition.y = localY;
      transform.localPosition = localPosition;
      return transform;
    }

    public static Transform SetLocalPositionRelativeToScreenEdge(this Transform transform, ScreenEdge edge, float offset) {
      float edgePosition = CalculateEdgePosition(edge);
      switch (edge) {
        case ScreenEdge.Left:
          transform.SetLocalX(edgePosition + offset);
          break;
        case ScreenEdge.Right:
          transform.SetLocalX(edgePosition + offset);
          break;
        case ScreenEdge.Top:
          transform.SetLocalY(edgePosition + offset);
          break;
        case ScreenEdge.Bottom:
          transform.SetLocalY(edgePosition + offset);
          break;
      }
      return transform;
    }
  }
}