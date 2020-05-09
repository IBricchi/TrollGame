// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster.inputactions'

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
            ""name"": ""Bob"",
            ""id"": ""bd1cae1a-a73f-47cf-ae60-9a39abf3708e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""aa09d890-d0e8-4b91-8229-1fe0c4e8f015"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8354650e-39a3-4faa-86ee-253aec11e1e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wasd"",
                    ""id"": ""11830978-0742-45fe-9d63-b6a806578b84"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d69439a3-de71-45b7-a5d6-4be54104db39"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a8265dab-d9af-4dee-84e9-3f5e76d7f12a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""134e439a-f226-40c7-92ad-30c420a3a42f"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a917d485-ce5d-4264-8929-ba9e5163984d"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0165b1b9-6446-48ec-87c3-b15ae35e56fa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""arrows"",
                    ""id"": ""35fac1f4-ae20-4625-b8d3-f66574c00b97"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""554009cc-06e3-4507-b766-df8e1d551d6b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""68593f57-e5dc-4551-a186-dfe61ac8063c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9429aba4-d9bb-4db9-ae54-1ec33f797aaf"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3b487308-8749-425e-867d-758eef63192c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""73284cae-f26b-4da6-ba84-d5e2bd2ea7d0"",
            ""actions"": [
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""2ed7aa39-ded0-4d08-b615-3f84dd15887b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c9f10d1c-a5ff-470a-9c53-96ee284c1907"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b502f24d-1e2a-4c19-b10a-faff87272701"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fba37102-c6c4-4328-8358-35d6486a6dcd"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Bob
        m_Bob = asset.FindActionMap("Bob", throwIfNotFound: true);
        m_Bob_Move = m_Bob.FindAction("Move", throwIfNotFound: true);
        m_Bob_Jump = m_Bob.FindAction("Jump", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Scroll = m_Camera.FindAction("Scroll", throwIfNotFound: true);
        m_Camera_Look = m_Camera.FindAction("Look", throwIfNotFound: true);
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

    // Bob
    private readonly InputActionMap m_Bob;
    private IBobActions m_BobActionsCallbackInterface;
    private readonly InputAction m_Bob_Move;
    private readonly InputAction m_Bob_Jump;
    public struct BobActions
    {
        private @InputMaster m_Wrapper;
        public BobActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Bob_Move;
        public InputAction @Jump => m_Wrapper.m_Bob_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Bob; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BobActions set) { return set.Get(); }
        public void SetCallbacks(IBobActions instance)
        {
            if (m_Wrapper.m_BobActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BobActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BobActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BobActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_BobActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BobActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BobActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_BobActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public BobActions @Bob => new BobActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Scroll;
    private readonly InputAction m_Camera_Look;
    public struct CameraActions
    {
        private @InputMaster m_Wrapper;
        public CameraActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Scroll => m_Wrapper.m_Camera_Scroll;
        public InputAction @Look => m_Wrapper.m_Camera_Look;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Scroll.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                @Look.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IBobActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnScroll(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
