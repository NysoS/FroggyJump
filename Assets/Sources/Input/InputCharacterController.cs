// GENERATED AUTOMATICALLY FROM 'Assets/Sources/Input/InputCharacterController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace FroggyJump.Input
{
    public class @InputCharacterController : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputCharacterController()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputCharacterController"",
    ""maps"": [
        {
            ""name"": ""PlayerController"",
            ""id"": ""520e4a39-3a0b-450d-a456-3901718fca65"",
            ""actions"": [
                {
                    ""name"": ""MoveActions"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f1b8e211-ce83-48fa-8726-cf1d51ec808e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""67f4cbda-02bc-454d-8d4b-df39347db2d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9ef28942-cd03-488f-b637-83b21667b3f3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveActions"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5717e9d9-cf05-439a-b403-c6fa4547464c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveActions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3032cd7e-d859-4012-a7d3-7a797ff3d7bb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveActions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""52bdf700-41b1-4235-91a5-e8c714c2a2bf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerController
            m_PlayerController = asset.FindActionMap("PlayerController", throwIfNotFound: true);
            m_PlayerController_MoveActions = m_PlayerController.FindAction("MoveActions", throwIfNotFound: true);
            m_PlayerController_Jump = m_PlayerController.FindAction("Jump", throwIfNotFound: true);
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

        // PlayerController
        private readonly InputActionMap m_PlayerController;
        private IPlayerControllerActions m_PlayerControllerActionsCallbackInterface;
        private readonly InputAction m_PlayerController_MoveActions;
        private readonly InputAction m_PlayerController_Jump;
        public struct PlayerControllerActions
        {
            private @InputCharacterController m_Wrapper;
            public PlayerControllerActions(@InputCharacterController wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveActions => m_Wrapper.m_PlayerController_MoveActions;
            public InputAction @Jump => m_Wrapper.m_PlayerController_Jump;
            public InputActionMap Get() { return m_Wrapper.m_PlayerController; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerControllerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerControllerActions instance)
            {
                if (m_Wrapper.m_PlayerControllerActionsCallbackInterface != null)
                {
                    @MoveActions.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMoveActions;
                    @MoveActions.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMoveActions;
                    @MoveActions.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMoveActions;
                    @Jump.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_PlayerControllerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveActions.started += instance.OnMoveActions;
                    @MoveActions.performed += instance.OnMoveActions;
                    @MoveActions.canceled += instance.OnMoveActions;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public PlayerControllerActions @PlayerController => new PlayerControllerActions(this);
        public interface IPlayerControllerActions
        {
            void OnMoveActions(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
    }
}
