using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using I2.Loc;

public class InkManagerDefeat : MonoBehaviour
{
    [SerializeField]
    private TextAsset _inkJsonAsset;
    private Story _story;

    [SerializeField]
    private Text _textField;

    [SerializeField]
    private VerticalLayoutGroup _choiceButtonContainer;
    [SerializeField]
    private Button _choiceButtonPrefab;

    [SerializeField]
    private Color _normalTextColor;
    [SerializeField]
    private Color _thoughtTextColor;

    private CharacterManager _characterManager;
    private BackgroundManager _backgroundManager;
    private int NextSceneToLoad;

    private int _currentLocIndex;
    private string _currentKnot;

    void Start()
    {
        _currentLocIndex = 1;
        _characterManager = FindObjectOfType<CharacterManager>();
        _backgroundManager = FindObjectOfType<BackgroundManager>();
        StartStory();
    }

    private void StartStory()
    {
        _story = new Story(_inkJsonAsset.text);

        _story.BindExternalFunction("ShowCharacter",
            (string name, string position, string mood) => _characterManager.ShowCharacter(name, position, mood));

        _story.BindExternalFunction("HideCharacter",
            (string name) => _characterManager.HideCharacter(name));

        _story.BindExternalFunction("ChangeMood",
            (string name, string mood) => _characterManager.ChangeMood(name, mood));
        _story.BindExternalFunction("ShowBackground",
            (string name, string sprite,string position) => _backgroundManager.ShowBackground(name, sprite,position));
        _story.BindExternalFunction("HideBackground",
            (string name) => _backgroundManager.HideBackground(name));

        _story.BindExternalFunction("ChangeBackground",
            (string name, string sprite) => _backgroundManager.ChangeBackground(name, sprite));
        InputSpacebar();
        //DisplayNextLine();
        RefreshChoiceView();
    }

    public void DisplayNextLine()
    {

        if (_story.canContinue)
        {
            string text = _story.Continue(); // gets next line

            var knot = _story.state.currentPathString?.Split('.')[0] ?? _currentKnot;
            //   Debug.Log($"knot: {knot}current: {_currentKnot}");

            if (_currentKnot != knot)
            {
                // new knot, reset values
                _currentKnot = knot;

                _currentLocIndex = 1;

                Debug.Log($"NEW KNOT: {_currentKnot}");

            }

            var key = $"{_currentKnot }_{_currentLocIndex}";
            // Debug.Log($"knot: {_currentKnot}locIndex: {_currentLocIndex}");



            var locText = LocalizationManager.GetTranslation($"KillerWinStory/{key}");

            locText = locText?.Trim(); // removes white space from text

            ApplyStyling();

            _textField.text = locText; // displays new text

            _currentLocIndex++;

        }
        else if (_story.currentChoices.Count > 0)
        {
            DisplayChoices();

        }
        else
        {
            NextScene();
            EndStory();
        }
    }
    private void InputSpacebar()
    {
          if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextLine();
        }

    }

    private void ApplyStyling()
    {
        if (_story.currentTags.Contains("thought"))
        {
            _textField.color = new Color(_textField.color.r, _textField.color.g, _textField.color.b, 0.5f);
            _textField.fontStyle = FontStyle.Italic;
        }
        else
        {
            _textField.color = new Color(_textField.color.r, _textField.color.g, _textField.color.b, 1f);
            _textField.fontStyle = FontStyle.Normal;
        }
    }

    private void DisplayChoices()
    {
        // check if choices are already being displayed
        if (_choiceButtonContainer.GetComponentsInChildren<Button>().Length > 0) return;

        for (int i = 0; i < _story.currentChoices.Count; i++)
        {
            var choice = _story.currentChoices[i];

            var key = $"{_currentKnot }_{_currentLocIndex}";

            var locText = LocalizationManager.GetTranslation($"KillerWinStory/{key}");

            Debug.Log($"knot: {_currentKnot}locIndex: {_currentLocIndex}");

            _currentLocIndex++;

            var button = CreateChoiceButton(locText);

            button.onClick.AddListener(() => OnClickChoiceButton(choice));
        }
    }

    Button CreateChoiceButton(string text)
    {
        // creates the button from a prefab
        var choiceButton = Instantiate(_choiceButtonPrefab);

        choiceButton.transform.SetParent(_choiceButtonContainer.transform, false);

        // sets text on the button
        var buttonText = choiceButton.GetComponentInChildren<Text>();
        buttonText.text = text;

        return choiceButton;
    }

    void OnClickChoiceButton(Choice choice)
    {
        _story.ChooseChoiceIndex(choice.index);
        _story.Continue();
        RefreshChoiceView();
        DisplayNextLine();
    }

    // Destroys all the old content and choices.
    void RefreshChoiceView()
    {
        if (_choiceButtonContainer != null)
        {
            foreach (var button in _choiceButtonContainer.GetComponentsInChildren<Button>())
            {
                Destroy(button.gameObject);
            }
        }
    }
    public void NextScene()
    {
        NextSceneToLoad = SceneManager.GetActiveScene().buildIndex -4;
        SceneManager.LoadScene(NextSceneToLoad);
    }
    private void EndStory()
    {
        
    }
}
