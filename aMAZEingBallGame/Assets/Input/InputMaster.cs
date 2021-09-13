// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f0ca03b3-7522-4b99-a150-c1ed2fcf71b4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""9b481ef6-98a9-489d-a893-eb3dc30ba581"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e7da69af-30e1-4af3-8551-e4c17f8d653f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltXp"",
                    ""type"": ""Button"",
                    ""id"": ""c5614eb4-2fc0-4f53-860b-d1d9fc494a7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltXm"",
                    ""type"": ""Button"",
                    ""id"": ""65c0208f-13d1-4bda-bf2b-3fcd40e6aaca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltZp"",
                    ""type"": ""Button"",
                    ""id"": ""63922765-f33d-4086-bfb4-013d1a522d6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltZm"",
                    ""type"": ""Button"",
                    ""id"": ""d9df2c17-82e7-4d86-8159-8d3731a060b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""da3a1484-1725-4bd1-9b0f-922228ee6db6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bd894b3a-3ca4-4308-9944-4bcce882d61f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cf85ad62-69bf-4e08-832c-909a2b851a67"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5374f3ab-960c-4a27-9d2a-e0bbfad381bb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""248aa0bb-513f-4ec3-8f0d-5aa3326dd1b7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""56751ce0-2a9a-4084-9500-0fd66e605765"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c78d76f0-0d82-4b34-99ed-7191dbe9251a"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""TiltXp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6be3398d-2a9e-4a51-8617-f46bb703dee5"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""TiltXm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c25d37d9-7311-4e73-a6f9-9613e4b181e2"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""TiltZp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ba9fcf6-859c-470d-a5c6-3f38920a41f5"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""TiltZm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""45e21984-8d69-4792-88a0-9fab73c6e3c0"",
            ""actions"": [
                {
                    ""name"": ""turnLeft"",
                    ""type"": ""Button"",
                    ""id"": ""6a9c9d5b-e8d4-462c-b132-a5c4ff9dafe2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""turnRight"",
                    ""type"": ""Button"",
                    ""id"": ""9ce415f1-b97e-49f8-b865-3e69123acaa1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""61b10a4f-88d4-45c8-bedb-c53e164c9461"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""turnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c3269bd-e685-40fd-8876-3af35cb6f402"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouses"",
                    ""action"": ""turnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard and mouses"",
            ""bindingGroup"": ""keyboard and mouses"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_TiltXp = m_Player.FindAction("TiltXp", throwIfNotFound: true);
        m_Player_TiltXm = m_Player.FindAction("TiltXm", throwIfNotFound: true);
        m_Player_TiltZp = m_Player.FindAction("TiltZp", throwIfNotFound: true);
        m_Player_TiltZm = m_Player.FindAction("TiltZm", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_turnLeft = m_Camera.FindAction("turnLeft", throwIfNotFound: true);
        m_Camera_turnRight = m_Camera.FindAction("turnRight", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_TiltXp;
    private readonly InputAction m_Player_TiltXm;
    private readonly InputAction m_Player_TiltZp;
    private readonly InputAction m_Player_TiltZm;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @TiltXp => m_Wrapper.m_Player_TiltXp;
        public InputAction @TiltXm => m_Wrapper.m_Player_TiltXm;
        public InputAction @TiltZp => m_Wrapper.m_Player_TiltZp;
        public InputAction @TiltZm => m_Wrapper.m_Player_TiltZm;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @TiltXp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltXp;
                @TiltXp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltXp;
                @TiltXp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltXp;
                @TiltXm.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltXm;
                @TiltXm.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltXm;
                @TiltXm.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltXm;
                @TiltZp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltZp;
                @TiltZp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltZp;
                @TiltZp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltZp;
                @TiltZm.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltZm;
                @TiltZm.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltZm;
                @TiltZm.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTiltZm;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @TiltXp.started += instance.OnTiltXp;
                @TiltXp.performed += instance.OnTiltXp;
                @TiltXp.canceled += instance.OnTiltXp;
                @TiltXm.started += instance.OnTiltXm;
                @TiltXm.performed += instance.OnTiltXm;
                @TiltXm.canceled += instance.OnTiltXm;
                @TiltZp.started += instance.OnTiltZp;
                @TiltZp.performed += instance.OnTiltZp;
                @TiltZp.canceled += instance.OnTiltZp;
                @TiltZm.started += instance.OnTiltZm;
                @TiltZm.performed += instance.OnTiltZm;
                @TiltZm.canceled += instance.OnTiltZm;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_turnLeft;
    private readonly InputAction m_Camera_turnRight;
    public struct CameraActions
    {
        private @InputMaster m_Wrapper;
        public CameraActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @turnLeft => m_Wrapper.m_Camera_turnLeft;
        public InputAction @turnRight => m_Wrapper.m_Camera_turnRight;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @turnLeft.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnTurnLeft;
                @turnLeft.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnTurnLeft;
                @turnLeft.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnTurnLeft;
                @turnRight.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnTurnRight;
                @turnRight.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnTurnRight;
                @turnRight.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnTurnRight;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @turnLeft.started += instance.OnTurnLeft;
                @turnLeft.performed += instance.OnTurnLeft;
                @turnLeft.canceled += instance.OnTurnLeft;
                @turnRight.started += instance.OnTurnRight;
                @turnRight.performed += instance.OnTurnRight;
                @turnRight.canceled += instance.OnTurnRight;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    private int m_keyboardandmousesSchemeIndex = -1;
    public InputControlScheme keyboardandmousesScheme
    {
        get
        {
            if (m_keyboardandmousesSchemeIndex == -1) m_keyboardandmousesSchemeIndex = asset.FindControlSchemeIndex("keyboard and mouses");
            return asset.controlSchemes[m_keyboardandmousesSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTiltXp(InputAction.CallbackContext context);
        void OnTiltXm(InputAction.CallbackContext context);
        void OnTiltZp(InputAction.CallbackContext context);
        void OnTiltZm(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnTurnLeft(InputAction.CallbackContext context);
        void OnTurnRight(InputAction.CallbackContext context);
    }
}
