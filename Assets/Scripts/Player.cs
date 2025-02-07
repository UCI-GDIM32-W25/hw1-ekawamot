using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft = 5;
    private int _numSeedsPlanted = 0;

    private void Start ()
    {
        
    }

    private void Update()
    {
         ///movement updates
         if(Input.GetKey(KeyCode.W))
         {
             _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
         }

         if(Input.GetKey(KeyCode.A))
         {
             _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
         }

         if(Input.GetKey(KeyCode.S))
         {
             _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
         }

         if(Input.GetKey(KeyCode.D))
         {
             _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
         }

         ///plant updates
         if(Input.GetKeyDown(KeyCode.Space))
         {
             if (_numSeeds > 0)
             {
                 PlantSeed();
                 _numSeeds = _numSeeds - 1;
                 _numSeedsLeft = _numSeeds;
                 _numSeedsPlanted = _numSeedsPlanted + 1;
                 _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
                 

             }
             
         }

         
         
         
    }

    public void PlantSeed ()
    {
        Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);
    }
}
