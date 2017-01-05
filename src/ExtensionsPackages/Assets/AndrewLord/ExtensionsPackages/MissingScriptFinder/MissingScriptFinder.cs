namespace AndrewLord.ExtensionsPackages.UnityMissingScriptFinder {

  using UnityEngine;
  using UnityEditor;

  public class MissingScriptFinder : EditorWindow {

    private int gameObjectCount = 0;
    private int componentsCount = 0;
    private int missingCount = 0;

    [MenuItem("Window/AndrewLord/ExtensionsPackages/MissingScriptFinder")]
    public static void ShowWindow() {
      EditorWindow.GetWindow(typeof(MissingScriptFinder));
    }

    public void OnGUI() {
      if (GUILayout.Button("Find Missing Scripts in selected GameObjects")) {
        Reset();
        FindInSelected();
      }
    }

    private void Reset() {
      gameObjectCount = 0;
      componentsCount = 0;
      missingCount = 0;
    }

    private void FindInSelected() {
      GameObject[] gameObjects = Selection.gameObjects;
      foreach (GameObject gameObject in gameObjects) {
        FindInGameObject(gameObject);
      }
      Debug.Log(string.Format("Searched {0} GameObjects, {1} components, found {2} missing", gameObjectCount, 
        componentsCount, missingCount));
    }

    private void FindInGameObject(GameObject gameObject) {
      gameObjectCount++;
      FindInComponents(gameObject);
      foreach (Transform childTransform in gameObject.transform) {
        FindInGameObject(childTransform.gameObject);
      }
    }

    private void FindInComponents(GameObject gameObject) {
      Component[] components = gameObject.GetComponents<Component>();
      for (int i = 0; i < components.Length; i++) {
        componentsCount++;
        if (components[i] == null) {
          missingCount++;
          string gameObjectName = gameObject.name;
          Transform transform = gameObject.transform;
          while (transform.parent != null) {
            gameObjectName = transform.parent.name + "/"+ gameObjectName;
            transform = transform.parent;
          }
          Debug.Log(gameObjectName + " has an empty script attached in position: " + i, gameObject);
        }
      }
    }
  }
}