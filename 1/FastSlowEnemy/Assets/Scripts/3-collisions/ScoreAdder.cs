using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag1;
    [SerializeField] string triggeringTag2;

    [SerializeField] NumberField scoreField;
    [SerializeField] int pointsToAddSlowEnemy;
    [SerializeField] int pointsToAddFastEnemy;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag1)
        {
            scoreField.SetNumber(scoreField.GetNumber() + pointsToAddSlowEnemy);
            GAME_STATUS.playerScore = scoreField.GetNumber(); // Keep the score for the next level
        }
        if (other.tag == triggeringTag2)
        {
            scoreField.SetNumber(scoreField.GetNumber() + pointsToAddFastEnemy);
            GAME_STATUS.playerScore = scoreField.GetNumber(); // Keep the score for the next level
        }
    }

    public void SetScoreField(NumberField newTextField)
    {
        this.scoreField = newTextField;
    }
}
