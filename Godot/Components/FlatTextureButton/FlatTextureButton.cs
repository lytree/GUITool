using Godot;
using System;
namespace Tool.Components;

public partial class FlatTextureButton : TextureButton
{
	[Export]
	public Color HoverTint { get; set; } = Colors.White;
	[Export]
	public Color PressedTint { get; set; } = Colors.White;
	[Export]
	public Color DisabledTint { get; set; } = Color.FromOkHsl(0.956f, 0.0f, 0.433f, 1.0f);

	private Color NormalTint;

	public void SetIsDisabled(bool isDisabled)
	{
		Disabled = isDisabled;
		UpdateTint();
	}
	public void Toggle()
	{
		ButtonPressed = !ButtonPressed;
	}
	public void OnToggled(bool toggled)
	{
		UpdateTint();
	}

	public void OnMouseEntered()
	{
		UpdateTint();
	}
	public void OnMouseExited()
	{
		UpdateTint();
	}
	public void UpdateTint()
	{
		if (Disabled)
		{
			SelfModulate = DisabledTint;
		}
		else if (ButtonPressed)
		{
			SelfModulate = PressedTint;
		}
		else if (IsHovered())
		{
			SelfModulate = HoverTint;
		}
		else
		{
			SelfModulate = NormalTint;
		}
	}

	public override void _Ready()
	{
		NormalTint = SelfModulate;
		MouseEntered += OnMouseEntered;
		MouseExited += OnMouseExited;
		Toggled += OnToggled;
		UpdateTint();
	}

	public override void _ExitTree()
	{
		MouseEntered -= OnMouseEntered;
		MouseExited -= OnMouseExited;
		Toggled -= OnToggled;
	}
}
