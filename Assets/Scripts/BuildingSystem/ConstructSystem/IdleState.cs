using System.Net.Sockets;
using UnityEngine;

public class IdleState : IConstructMode
{
    private ConstructController controller;

    public IdleState(ConstructController controller)
    {
        this.controller = controller;
    }

    public void OnEnter()
    {
        Debug.Log("일반 상태 진입");
        controller.ClearSlotHighlight();
    }

    public void OnUpdate()
    {
    }

    public void OnExit()
    {
    }

    public void PerformMainAction()
    {
        ConstructModel model = controller.Model;

        if (model.HoveredTower != null)
        {
            model.SelectedTower = model.HoveredTower;
            controller.ChangeState<SelectState>();
        }
    }

    public void CancelMainAction() { }
    public void PerformSubAction() { }


}
