using UnityEngine;

public class WorldItem : MonoBehaviour, IInteractable
{
    [SerializeField] private MushroomData _data;

    public string InteractionHint => $"Собрать: {_data.mushroomName}";

    public void Interact(PlayerInteractor interactor)
    {
        interactor.Inventory.Add(_data);
        Destroy(gameObject);
    }
}