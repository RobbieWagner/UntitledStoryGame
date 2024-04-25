//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Tutorial/TutorialControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @TutorialControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TutorialControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TutorialControls"",
    ""maps"": [
        {
            ""name"": ""Tutorial"",
            ""id"": ""6abced40-dd62-4213-bc44-ddd518c9705f"",
            ""actions"": [
                {
                    ""name"": ""CloseTutorial"",
                    ""type"": ""Button"",
                    ""id"": ""73e6c922-f0bc-4a36-bddf-39f53c8a8be5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""c7e89d01-83fd-4d7d-8345-83078145739b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""NextAxis"",
                    ""type"": ""Button"",
                    ""id"": ""48e649c9-8dcc-46de-b21c-0ea41da18ec6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Previous"",
                    ""type"": ""Button"",
                    ""id"": ""9e37e3ce-0e1a-43be-b554-eaf1434b7b10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""95a43491-8228-4890-a881-8b154b80e77e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseTutorial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""672285e9-c24b-4c80-befe-1a10f101e306"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseTutorial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea1ddb28-278e-4466-b6a1-bf221c5251f0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseTutorial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a26f90fa-cb1e-42e8-9c60-2c4bb5fb2d1e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseTutorial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1ab926e-e327-4700-8377-a2261b6f38d1"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e46a897-85fd-4525-9100-61360c07cfc6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""234671cf-14a4-4d1c-bf72-84b009fb61d9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb451180-e9d8-4e05-9f98-31110f684f0d"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71b73902-d2cd-4f96-ba6e-5337dcabf1f2"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94d45719-4e71-4054-a370-29a012c48677"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec542b5d-3d40-4446-b157-a4d9b47d0bf1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbb5c727-2284-46d7-8d2d-6528322bdbb9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Tutorial
        m_Tutorial = asset.FindActionMap("Tutorial", throwIfNotFound: true);
        m_Tutorial_CloseTutorial = m_Tutorial.FindAction("CloseTutorial", throwIfNotFound: true);
        m_Tutorial_Next = m_Tutorial.FindAction("Next", throwIfNotFound: true);
        m_Tutorial_NextAxis = m_Tutorial.FindAction("NextAxis", throwIfNotFound: true);
        m_Tutorial_Previous = m_Tutorial.FindAction("Previous", throwIfNotFound: true);
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

    // Tutorial
    private readonly InputActionMap m_Tutorial;
    private List<ITutorialActions> m_TutorialActionsCallbackInterfaces = new List<ITutorialActions>();
    private readonly InputAction m_Tutorial_CloseTutorial;
    private readonly InputAction m_Tutorial_Next;
    private readonly InputAction m_Tutorial_NextAxis;
    private readonly InputAction m_Tutorial_Previous;
    public struct TutorialActions
    {
        private @TutorialControls m_Wrapper;
        public TutorialActions(@TutorialControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CloseTutorial => m_Wrapper.m_Tutorial_CloseTutorial;
        public InputAction @Next => m_Wrapper.m_Tutorial_Next;
        public InputAction @NextAxis => m_Wrapper.m_Tutorial_NextAxis;
        public InputAction @Previous => m_Wrapper.m_Tutorial_Previous;
        public InputActionMap Get() { return m_Wrapper.m_Tutorial; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TutorialActions set) { return set.Get(); }
        public void AddCallbacks(ITutorialActions instance)
        {
            if (instance == null || m_Wrapper.m_TutorialActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TutorialActionsCallbackInterfaces.Add(instance);
            @CloseTutorial.started += instance.OnCloseTutorial;
            @CloseTutorial.performed += instance.OnCloseTutorial;
            @CloseTutorial.canceled += instance.OnCloseTutorial;
            @Next.started += instance.OnNext;
            @Next.performed += instance.OnNext;
            @Next.canceled += instance.OnNext;
            @NextAxis.started += instance.OnNextAxis;
            @NextAxis.performed += instance.OnNextAxis;
            @NextAxis.canceled += instance.OnNextAxis;
            @Previous.started += instance.OnPrevious;
            @Previous.performed += instance.OnPrevious;
            @Previous.canceled += instance.OnPrevious;
        }

        private void UnregisterCallbacks(ITutorialActions instance)
        {
            @CloseTutorial.started -= instance.OnCloseTutorial;
            @CloseTutorial.performed -= instance.OnCloseTutorial;
            @CloseTutorial.canceled -= instance.OnCloseTutorial;
            @Next.started -= instance.OnNext;
            @Next.performed -= instance.OnNext;
            @Next.canceled -= instance.OnNext;
            @NextAxis.started -= instance.OnNextAxis;
            @NextAxis.performed -= instance.OnNextAxis;
            @NextAxis.canceled -= instance.OnNextAxis;
            @Previous.started -= instance.OnPrevious;
            @Previous.performed -= instance.OnPrevious;
            @Previous.canceled -= instance.OnPrevious;
        }

        public void RemoveCallbacks(ITutorialActions instance)
        {
            if (m_Wrapper.m_TutorialActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITutorialActions instance)
        {
            foreach (var item in m_Wrapper.m_TutorialActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TutorialActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TutorialActions @Tutorial => new TutorialActions(this);
    public interface ITutorialActions
    {
        void OnCloseTutorial(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnNextAxis(InputAction.CallbackContext context);
        void OnPrevious(InputAction.CallbackContext context);
    }
}
