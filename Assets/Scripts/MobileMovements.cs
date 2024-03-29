using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MobileMovements : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MobileMovements()
    {
        asset = InputActionAsset.FromJson(@"{
            ""name"": ""MobileMovements"",
            ""maps"": [
                {
                    ""name"": ""MobileMovementMap"",
                    ""id"": ""9ae03f8c-6de5-47eb-8bd0-aa84fe4fc375"",
                    ""actions"": [
                        {
                            ""name"": ""Movement"",
                            ""type"": ""Value"",
                            ""id"": ""d0851eac-cce5-4259-9868-c4f12373aec2"",
                            ""expectedControlType"": ""Vector2"",
                            ""processors"": """",
                            ""interactions"": """",
                            ""initialStateCheck"": true
                        },
                        {
                            ""name"": ""Jump"",
                            ""type"": ""Button"",
                            ""id"": ""dd2f42d1-af99-4ee4-9eb4-2a3cd1be06a2"",
                            ""expectedControlType"": ""Button"",
                            ""processors"": """",
                            ""interactions"": """",
                            ""initialStateCheck"": true
                        },
                        {
                            ""name"": ""Touch0"",
                            ""type"": ""PassThrough"",
                            ""id"": ""18954aa4-1a6b-4e30-8a0b-9c77a2ed5629"",
                            ""expectedControlType"": ""Touch"",
                            ""processors"": """",
                            ""interactions"": """",
                            ""initialStateCheck"": false
                        },
                        {
                            ""name"": ""Touch1"",
                            ""type"": ""PassThrough"",
                            ""id"": ""86d44faa-ea5f-4658-91fb-d7611f242796"",
                            ""expectedControlType"": ""Touch"",
                            ""processors"": """",
                            ""interactions"": """",
                            ""initialStateCheck"": false
                        }
                    ],
                    ""bindings"": [
                        {
                            ""name"": ""2D Vector"",
                            ""id"": ""93bc8a06-395c-4268-a3da-758bd6b350bb"",
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
                            ""id"": ""7002685d-dcaa-44fc-81a2-b82a16b91af3"",
                            ""path"": """",
                            ""interactions"": """",
                            ""processors"": """",
                            ""groups"": ""MobileMovements"",
                            ""action"": ""Movement"",
                            ""isComposite"": false,
                            ""isPartOfComposite"": true
                        },
                        {
                            ""name"": ""down"",
                            ""id"": ""d7b9329a-f8fb-4710-9755-2140a1563a1f"",
                            ""path"": """",
                            ""interactions"": """",
                            ""processors"": """",
                            ""groups"": ""MobileMovements"",
                            ""action"": ""Movement"",
                            ""isComposite"": false,
                            ""isPartOfComposite"": true
                        },
                        {
                            ""name"": ""left"",
                            ""id"": ""eee5291a-76d1-43a9-bbc9-c6454902215b"",
                            ""path"": ""<Keyboard>/leftArrow"",
                            ""interactions"": """",
                            ""processors"": """",
                            ""groups"": ""MobileMovements"",
                            ""action"": ""Movement"",
                            ""isComposite"": false,
                            ""isPartOfComposite"": true
                        },
                        {
                            ""name"": ""right"",
                            ""id"": ""332588d5-f091-41db-85d3-6ba0315d8e91"",
                            ""path"": ""<Keyboard>/rightArrow"",
                            ""interactions"": """",
                            ""processors"": """",
                            ""groups"": ""MobileMovements"",
                            ""action"": ""Movement"",
                            ""isComposite"": false,
                            ""isPartOfComposite"": true
                        },
                        {
                            ""name"": """",
                            ""id"": ""01d61742-c558-4aef-aed1-bad699e7c2b1"",
                            ""path"": ""<Touchscreen>/primaryTouch/press"",
                            ""interactions"": ""Press"",
                            ""processors"": """",
                            ""groups"": ""MobileMovements"",
                            ""action"": ""Jump"",
                            ""isComposite"": false,
                            ""isPartOfComposite"": false
                        },
                        {
                            ""name"": """",
                            ""id"": ""e69da264-9c3f-4a24-9cee-55fbc2b78887"",
                            ""path"": ""<Touchscreen>/touch0"",
                            ""interactions"": """",
                            ""processors"": """",
                            ""groups"": ""MobileMovements"",
                            ""action"": ""Touch0"",
                            ""isComposite"": false,
                            ""isPartOfComposite"": false
                        },
                        {
                            ""name"": """",
                            ""id"": ""2f4c613d-54e2-4422-9ed0-0ceb8b086732"",
                            ""path"": ""<Touchscreen>/touch1"",
                            ""interactions"": """",
                            ""processors"": """",
                            ""groups"": ""MobileMovements"",
                            ""action"": ""Touch1"",
                            ""isComposite"": false,
                            ""isPartOfComposite"": false
                        }
                    ]
                }
            ],
            ""controlSchemes"": [
                {
                    ""name"": ""MobileMovements"",
                    ""bindingGroup"": ""MobileMovements"",
                    ""devices"": [
                        {
                            ""devicePath"": ""<Keyboard>"",
                            ""isOptional"": false,
                            ""isOR"": false
                        },
                        {
                            ""devicePath"": ""<Touchscreen>"",
                            ""isOptional"": false,
                            ""isOR"": false
                        }
                    ]
                }
            ]
        }");
        // MobileMovementMap
        m_MobileMovementMap = asset.FindActionMap("MobileMovementMap", throwIfNotFound: true);
        m_MobileMovementMap_Movement = m_MobileMovementMap.FindAction("Movement", throwIfNotFound: true);
        m_MobileMovementMap_Jump = m_MobileMovementMap.FindAction("Jump", throwIfNotFound: true);
        m_MobileMovementMap_Touch0 = m_MobileMovementMap.FindAction("Touch0", throwIfNotFound: true);
        m_MobileMovementMap_Touch1 = m_MobileMovementMap.FindAction("Touch1", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MobileMovementMap
    private readonly InputActionMap m_MobileMovementMap;
    private IMobileMovementMapActions m_MobileMovementMapActionsCallbackInterface;
    private readonly InputAction m_MobileMovementMap_Movement;
    private readonly InputAction m_MobileMovementMap_Jump;
    private readonly InputAction m_MobileMovementMap_Touch0;
    private readonly InputAction m_MobileMovementMap_Touch1;
    public struct MobileMovementMapActions
    {
        private @MobileMovements m_Wrapper;
        public MobileMovementMapActions(@MobileMovements wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_MobileMovementMap_Movement;
        public InputAction @Jump => m_Wrapper.m_MobileMovementMap_Jump;
        public InputAction @Touch0 => m_Wrapper.m_MobileMovementMap_Touch0;
        public InputAction @Touch1 => m_Wrapper.m_MobileMovementMap_Touch1;
        public InputActionMap Get() { return m_Wrapper.m_MobileMovementMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MobileMovementMapActions set) { return set.Get(); }
        public void SetCallbacks(IMobileMovementMapActions instance)
        {
            if (m_Wrapper.m_MobileMovementMapActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnJump;
                @Touch0.started -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnTouch0;
                @Touch0.performed -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnTouch0;
                @Touch0.canceled -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnTouch0;
                @Touch1.started -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnTouch1;
                @Touch1.performed -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnTouch1;
                @Touch1.canceled -= m_Wrapper.m_MobileMovementMapActionsCallbackInterface.OnTouch1;
            }
            m_Wrapper.m_MobileMovementMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Touch0.started += instance.OnTouch0;
                @Touch0.performed += instance.OnTouch0;
                @Touch0.canceled += instance.OnTouch0;
                @Touch1.started += instance.OnTouch1;
                @Touch1.performed += instance.OnTouch1;
                @Touch1.canceled += instance.OnTouch1;
            }
        }
    }
    public MobileMovementMapActions @MobileMovementMap => new MobileMovementMapActions(this);
    private int m_MobileMovementsSchemeIndex = -1;
    public InputControlScheme MobileMovementsScheme
    {
        get
        {
            if (m_MobileMovementsSchemeIndex == -1) m_MobileMovementsSchemeIndex = asset.FindControlSchemeIndex("MobileMovements");
            return asset.controlSchemes[m_MobileMovementsSchemeIndex];
        }
    }
    public interface IMobileMovementMapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTouch0(InputAction.CallbackContext context);
        void OnTouch1(InputAction.CallbackContext context);
    }
}