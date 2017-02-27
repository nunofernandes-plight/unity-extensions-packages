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

    public static void SetAnchorMinY(this RectTransform transform, float y) {
      Vector2 anchorMin = transform.anchorMin;
      anchorMin.y = y;
      transform.anchorMin = anchorMin;
    }

    public static void SetAnchorMaxY(this RectTransform transform, float y) {
      Vector2 anchorMax = transform.anchorMax;
      anchorMax.y = y;
      transform.anchorMax = anchorMax;
    }

    public static void SetAnchorsX(this RectTransform transform, float x) {
      transform.SetAnchorMinX(x);
      transform.SetAnchorMaxX(x);
    }

    public static void SetAnchorsY(this RectTransform transform, float y) {
      transform.SetAnchorMinY(y);
      transform.SetAnchorMaxY(y);
    }

    public static void SetAnchoredPositionX(this RectTransform transform, float x) {
      Vector2 anchorPosition = transform.anchoredPosition;
      anchorPosition.x = x;
      transform.anchoredPosition = anchorPosition;
    }
    
    public static void SetAnchoredPositionY(this RectTransform transform, float y) {
      Vector2 anchorPosition = transform.anchoredPosition;
      anchorPosition.y = y;
      transform.anchoredPosition = anchorPosition;
    }
  }
}