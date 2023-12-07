using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private Transform _shelfPrefab;
    
    private void Start()
    {
        var shel = Instantiate(_shelfPrefab); // Эту строку кода удалять нельзя
        
        Destroy(shel.gameObject);
    }
}
