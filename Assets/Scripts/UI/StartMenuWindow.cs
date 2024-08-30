using CookingPrototype.Controllers;
using UnityEngine;
using UnityEngine.UI;


namespace CookingPrototype.UI {
	class StartMenuWindow:MonoBehaviour {
		[SerializeField] private Button _startButton;
		private bool _isInit;
		public void Show() {
			if ( !_isInit ) {
				_isInit = true;
				Init();
			}
			ToggleWindow(true);
		}

		public void Hide() {
			ToggleWindow(false);
		}
		private void ToggleWindow(bool enable) {
			gameObject.SetActive(enable);
			for ( var i = 0; i < transform.childCount; ++i )
			{
				transform.GetChild(i).gameObject.SetActive(enable);
			}
		}
		public void Init() {
			_startButton.onClick.AddListener(GameplayController.Instance.StartGame);
		}
	}
}
