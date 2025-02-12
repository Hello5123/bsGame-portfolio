//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_BsScripts/InputSystem/PlayerInputs.inputactions
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

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""29ee7a5b-b69a-4a72-a327-6ebebb65c85e"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""44a73018-f37c-4656-a186-85fabc98572e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Mash(tapDelay=0.15,pressPoint=0.1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressW"",
                    ""type"": ""Button"",
                    ""id"": ""f8beacc7-206b-4bee-bf45-6c324c28a19c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressS"",
                    ""type"": ""Button"",
                    ""id"": ""1b75e17c-eebd-491f-8a1c-b2ae0bb1ab72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressA"",
                    ""type"": ""Button"",
                    ""id"": ""95102af0-a895-4c23-84ce-8247be9c882b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressD"",
                    ""type"": ""Button"",
                    ""id"": ""0ae21bbd-6f4c-42f6-b324-a6619ecdc852"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ReleaseW"",
                    ""type"": ""Button"",
                    ""id"": ""b9c5990c-512f-47e9-b39a-ddad122c6a95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1.401298E-45,behavior=1)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ReleaseS"",
                    ""type"": ""Button"",
                    ""id"": ""92ef1c65-1847-4b58-839b-243461b7f3c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1.401298E-45,behavior=1)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ReleaseA"",
                    ""type"": ""Button"",
                    ""id"": ""678f9919-aeae-4534-b4e1-d36edc6fa725"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1.401298E-45,behavior=1)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ReleaseD"",
                    ""type"": ""Button"",
                    ""id"": ""0e9f5abf-e208-456c-9b88-db16f96e5736"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1.401298E-45,behavior=1)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveAnim"",
                    ""type"": ""Button"",
                    ""id"": ""3d81a626-4c03-49fd-86a8-524847396dd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Mash(tapDelay=0.15,pressPoint=0.1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skill"",
                    ""type"": ""Button"",
                    ""id"": ""bcb0285b-fca1-43bf-9332-61b6cbde6c4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""63d8d49b-324b-4828-b7dd-fc2b5f2c05db"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""360abe4f-5e7e-4ddf-91e8-db68df895e49"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PressW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8763036-e9e1-43a8-99e2-b4512dbd4178"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PressS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ea85f78-10ac-474c-ad2d-8cbddeedd3aa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PressA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c20d893e-741e-4856-96da-16d6afd7c355"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PressD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""393f621d-b2aa-447b-8828-bf99402376ea"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ReleaseW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6715c6b2-15a4-4064-992a-ee97625b414b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ReleaseS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a8d11be-3fa2-40b1-bdb2-6b74799e757a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ReleaseA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1453b2d-fbd6-43ec-970f-56a6c9f39ef8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReleaseD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82687efa-d710-4f6b-9d73-c5a6f28383ce"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAnim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3257c36a-7740-4a28-9165-6680249f7274"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAnim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f19abb61-bb34-4bd2-919e-a9b7385caceb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAnim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63248cc9-9643-4e13-8bbe-49c1e222362a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveAnim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb8498da-3e26-44e2-996c-b7a94545367c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
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
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_PressW = m_Player.FindAction("PressW", throwIfNotFound: true);
        m_Player_PressS = m_Player.FindAction("PressS", throwIfNotFound: true);
        m_Player_PressA = m_Player.FindAction("PressA", throwIfNotFound: true);
        m_Player_PressD = m_Player.FindAction("PressD", throwIfNotFound: true);
        m_Player_ReleaseW = m_Player.FindAction("ReleaseW", throwIfNotFound: true);
        m_Player_ReleaseS = m_Player.FindAction("ReleaseS", throwIfNotFound: true);
        m_Player_ReleaseA = m_Player.FindAction("ReleaseA", throwIfNotFound: true);
        m_Player_ReleaseD = m_Player.FindAction("ReleaseD", throwIfNotFound: true);
        m_Player_MoveAnim = m_Player.FindAction("MoveAnim", throwIfNotFound: true);
        m_Player_Skill = m_Player.FindAction("Skill", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_PressW;
    private readonly InputAction m_Player_PressS;
    private readonly InputAction m_Player_PressA;
    private readonly InputAction m_Player_PressD;
    private readonly InputAction m_Player_ReleaseW;
    private readonly InputAction m_Player_ReleaseS;
    private readonly InputAction m_Player_ReleaseA;
    private readonly InputAction m_Player_ReleaseD;
    private readonly InputAction m_Player_MoveAnim;
    private readonly InputAction m_Player_Skill;
    public struct PlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @PressW => m_Wrapper.m_Player_PressW;
        public InputAction @PressS => m_Wrapper.m_Player_PressS;
        public InputAction @PressA => m_Wrapper.m_Player_PressA;
        public InputAction @PressD => m_Wrapper.m_Player_PressD;
        public InputAction @ReleaseW => m_Wrapper.m_Player_ReleaseW;
        public InputAction @ReleaseS => m_Wrapper.m_Player_ReleaseS;
        public InputAction @ReleaseA => m_Wrapper.m_Player_ReleaseA;
        public InputAction @ReleaseD => m_Wrapper.m_Player_ReleaseD;
        public InputAction @MoveAnim => m_Wrapper.m_Player_MoveAnim;
        public InputAction @Skill => m_Wrapper.m_Player_Skill;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @PressW.started += instance.OnPressW;
            @PressW.performed += instance.OnPressW;
            @PressW.canceled += instance.OnPressW;
            @PressS.started += instance.OnPressS;
            @PressS.performed += instance.OnPressS;
            @PressS.canceled += instance.OnPressS;
            @PressA.started += instance.OnPressA;
            @PressA.performed += instance.OnPressA;
            @PressA.canceled += instance.OnPressA;
            @PressD.started += instance.OnPressD;
            @PressD.performed += instance.OnPressD;
            @PressD.canceled += instance.OnPressD;
            @ReleaseW.started += instance.OnReleaseW;
            @ReleaseW.performed += instance.OnReleaseW;
            @ReleaseW.canceled += instance.OnReleaseW;
            @ReleaseS.started += instance.OnReleaseS;
            @ReleaseS.performed += instance.OnReleaseS;
            @ReleaseS.canceled += instance.OnReleaseS;
            @ReleaseA.started += instance.OnReleaseA;
            @ReleaseA.performed += instance.OnReleaseA;
            @ReleaseA.canceled += instance.OnReleaseA;
            @ReleaseD.started += instance.OnReleaseD;
            @ReleaseD.performed += instance.OnReleaseD;
            @ReleaseD.canceled += instance.OnReleaseD;
            @MoveAnim.started += instance.OnMoveAnim;
            @MoveAnim.performed += instance.OnMoveAnim;
            @MoveAnim.canceled += instance.OnMoveAnim;
            @Skill.started += instance.OnSkill;
            @Skill.performed += instance.OnSkill;
            @Skill.canceled += instance.OnSkill;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @PressW.started -= instance.OnPressW;
            @PressW.performed -= instance.OnPressW;
            @PressW.canceled -= instance.OnPressW;
            @PressS.started -= instance.OnPressS;
            @PressS.performed -= instance.OnPressS;
            @PressS.canceled -= instance.OnPressS;
            @PressA.started -= instance.OnPressA;
            @PressA.performed -= instance.OnPressA;
            @PressA.canceled -= instance.OnPressA;
            @PressD.started -= instance.OnPressD;
            @PressD.performed -= instance.OnPressD;
            @PressD.canceled -= instance.OnPressD;
            @ReleaseW.started -= instance.OnReleaseW;
            @ReleaseW.performed -= instance.OnReleaseW;
            @ReleaseW.canceled -= instance.OnReleaseW;
            @ReleaseS.started -= instance.OnReleaseS;
            @ReleaseS.performed -= instance.OnReleaseS;
            @ReleaseS.canceled -= instance.OnReleaseS;
            @ReleaseA.started -= instance.OnReleaseA;
            @ReleaseA.performed -= instance.OnReleaseA;
            @ReleaseA.canceled -= instance.OnReleaseA;
            @ReleaseD.started -= instance.OnReleaseD;
            @ReleaseD.performed -= instance.OnReleaseD;
            @ReleaseD.canceled -= instance.OnReleaseD;
            @MoveAnim.started -= instance.OnMoveAnim;
            @MoveAnim.performed -= instance.OnMoveAnim;
            @MoveAnim.canceled -= instance.OnMoveAnim;
            @Skill.started -= instance.OnSkill;
            @Skill.performed -= instance.OnSkill;
            @Skill.canceled -= instance.OnSkill;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnPressW(InputAction.CallbackContext context);
        void OnPressS(InputAction.CallbackContext context);
        void OnPressA(InputAction.CallbackContext context);
        void OnPressD(InputAction.CallbackContext context);
        void OnReleaseW(InputAction.CallbackContext context);
        void OnReleaseS(InputAction.CallbackContext context);
        void OnReleaseA(InputAction.CallbackContext context);
        void OnReleaseD(InputAction.CallbackContext context);
        void OnMoveAnim(InputAction.CallbackContext context);
        void OnSkill(InputAction.CallbackContext context);
    }
}
