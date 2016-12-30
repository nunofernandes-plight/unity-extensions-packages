namespace AndrewLord.ExtensionsPackages.RectTransformAnchor {

  using UnityEngine;

  public static class RectTransformAnchorExtension {

    public static void SetAnchorMinX(this RectTransform transform, float x) {
      Vector2 anchorMin = transform.anchorMin;
      anchorMin.x = x;
      transform.anchorMin = anchorMin;
    }

    public static void SetAnchorMaxX(this RectTransform transform, float x) {
      Vector2 anchorMax = transform.anchorMax;
      anchorMax.x = x;
      transform.anchorMax = anchorMax;
    }

    public static void SetAnchorsX(this RectTransform transform, float x) {
      transform.SetAnchorMinX(x);
      transform.SetAnchorMaxX(x);
    }

    public static void SetAnchoredPositionX(this RectTransform transform, float x) {
      Vector2 anchorPosition = transform.anchoredPosition;
      anchorPosition.x = x;
      transform.anchoredPosition = anchorPosition;
    }
  }
}