using UnityEngine;
[ExecuteInEditMode]
public class ScreenEffect : MonoBehaviour
{
	[SerializeField] private Material _customImageEffect;
	
	protected void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		if (_customImageEffect != null)
			Graphics.Blit(src, dest, _customImageEffect);
	}
}
