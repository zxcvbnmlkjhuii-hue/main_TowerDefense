using System;
using UnityEngine.UI;
using UnityEngine;

public class ConstructView : MonoBehaviour
{
    [Header("시각적 렌더러")]
    public BuildingPreviewRenderer previewRenderer;

    [Header("타워 선택 UI")]
    public UI_TowerInteract towerInteractUI;

    public void CreatePreview(GameObject previewPF)
    {
        previewRenderer.CreatePreview(previewPF);
    }

    public void UpdatePreview(Vector3 pos, bool isValid)
    {
        previewRenderer.UpdateTransform(pos, Quaternion.identity);
        previewRenderer.SetValidityColor(isValid);
        previewRenderer.ShowPreview(true);
    }

    public void HidePreview()
    {
        previewRenderer.ShowPreview(false);
    }

    public void ShowTowerMenu(Vector3 worldPos)
    {
        if (towerInteractUI != null)
            towerInteractUI.Show(worldPos);
    }

    public void HideTowerMenu()
    {
        if (towerInteractUI != null)
            towerInteractUI.Hide();
    }
}
