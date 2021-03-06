using UnityEngine;
using UnityEngine.InputSystem;

public class InputActions : MonoBehaviour
{
	[Header("Character Input Values")]
	public Vector2 move;
	public Vector2 look;
	public bool jump;
	public bool primaryAttack;
	public bool secondaryAttack;
	public bool sprint;

	[Header("Movement Settings")]
	public bool analogMovement;

	[Header("Mouse Cursor Settings")]
	public bool cursorLocked = true;
	public bool cursorInputForLook = true;

	//on action
	public void OnMove(InputValue value)
	{
		MoveInput(value.Get<Vector2>());
	}

	public void OnLook(InputValue value)
	{
		if(cursorInputForLook)
		{
			LookInput(value.Get<Vector2>());
		}
	}

	public void OnJump(InputValue value)
	{
		JumpInput(value.isPressed);
	}

	public void OnPrimaryAttack(InputValue value)
	{
		PrimaryAttackInput(value.isPressed);
	}

	public void OnSecondaryAttack(InputValue value)
	{
		SecondaryAttackInput(value.isPressed);
	}

	public void OnSprint(InputValue value)
	{
		SprintInput(value.isPressed);
	}

	//inputs
	public void MoveInput(Vector2 newMoveDirection)
	{
		move = newMoveDirection;
	}

	public void LookInput(Vector2 newLookDirection)
	{
		look = newLookDirection;
	}

	public void JumpInput(bool newJumpState)
	{
		jump = newJumpState;
	}

	public void PrimaryAttackInput(bool newPrimaryAttack)
	{
		primaryAttack = newPrimaryAttack;
	}

	public void SecondaryAttackInput(bool newSecondaryAttack)
	{
		secondaryAttack = newSecondaryAttack;
	}

	public void SprintInput(bool newSprintState)
	{
		sprint = newSprintState;
	}

	private void OnApplicationFocus(bool hasFocus)
	{
		SetCursorState(cursorLocked);
	}

	private void SetCursorState(bool newState)
	{
		Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
	}
}
