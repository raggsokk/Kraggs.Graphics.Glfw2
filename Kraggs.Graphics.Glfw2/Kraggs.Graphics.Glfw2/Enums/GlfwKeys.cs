#region License
/*
Copyright (c) 2012 Jarle Hansen <jarle.hansen@gmail.com>

This software is provided 'as-is', without any express or implied
warranty. In no event will the authors be held liable for any damages
arising from the use of this software.

Permission is granted to anyone to use this software for any purpose,
including commercial applications, and to alter it and redistribute it
freely, subject to the following restrictions:

1. The origin of this software must not be misrepresented; you must not
   claim that you wrote the original software. If you use this software
   in a product, an acknowledgment in the product documentation would
   be appreciated but is not required.

2. Altered source versions must be plainly marked as such, and must not
   be misrepresented as being the original software.

3. This notice may not be removed or altered from any source
   distribution.
*/
#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraggs.Graphics.Glfw2
{
    public enum GlfwKeys
    {
        Space = GLFWConstants.GLFW_KEY_SPACE,
        Escape = GLFWConstants.GLFW_KEY_ESC,

        Up = GLFWConstants.GLFW_KEY_UP,
        Down = GLFWConstants.GLFW_KEY_DOWN,
        Left = GLFWConstants.GLFW_KEY_LEFT,
        Right = GLFWConstants.GLFW_KEY_RIGHT,

        ShiftLeft = GLFWConstants.GLFW_KEY_LSHIFT,
        ShiftRight = GLFWConstants.GLFW_KEY_RSHIFT,

        CtrlLeft = GLFWConstants.GLFW_KEY_LCTRL,
        CtrlRight = GLFWConstants.GLFW_KEY_RCTRL,

        AltLeft = GLFWConstants.GLFW_KEY_LALT,
        AltRight = GLFWConstants.GLFW_KEY_RALT,

        SuperLeft = GLFWConstants.GLFW_KEY_LSUPER,
        SuperRight = GLFWConstants.GLFW_KEY_RSUPER,

        Tab = GLFWConstants.GLFW_KEY_TAB,
        Enter = GLFWConstants.GLFW_KEY_ENTER,
        BackSpace = GLFWConstants.GLFW_KEY_BACKSPACE,
        Insert = GLFWConstants.GLFW_KEY_INSERT,
        Delete = GLFWConstants.GLFW_KEY_DEL,
        PageUp = GLFWConstants.GLFW_KEY_PAGEUP,
        PageDown = GLFWConstants.GLFW_KEY_PAGEDOWN,
        Home = GLFWConstants.GLFW_KEY_HOME,
        End = GLFWConstants.GLFW_KEY_END,

        // keypad
        Keypad0 = GLFWConstants.GLFW_KEY_KP_0,
        Keypad1 = GLFWConstants.GLFW_KEY_KP_1,
        Keypad2 = GLFWConstants.GLFW_KEY_KP_2,
        Keypad3 = GLFWConstants.GLFW_KEY_KP_3,
        Keypad4 = GLFWConstants.GLFW_KEY_KP_4,
        Keypad5 = GLFWConstants.GLFW_KEY_KP_5,
        Keypad6 = GLFWConstants.GLFW_KEY_KP_6,
        Keypad7 = GLFWConstants.GLFW_KEY_KP_7,
        Keypad8 = GLFWConstants.GLFW_KEY_KP_8,
        Keypad9 = GLFWConstants.GLFW_KEY_KP_9,

        KeypadDivide = GLFWConstants.GLFW_KEY_KP_DIVIDE,
        KeypadMultiply = GLFWConstants.GLFW_KEY_KP_MULTIPLY,
        KeypadSubtract = GLFWConstants.GLFW_KEY_KP_SUBTRACT,
        KeypadAdd = GLFWConstants.GLFW_KEY_KP_ADD,
        KeypadDecimal = GLFWConstants.GLFW_KEY_KP_DECIMAL,
        KeypadEqual = GLFWConstants.GLFW_KEY_KP_EQUAL,
        KeypadEnter = GLFWConstants.GLFW_KEY_KP_ENTER,
        KeypadNumLock = GLFWConstants.GLFW_KEY_KP_NUM_LOCK,

        CapsLock = GLFWConstants.GLFW_KEY_CAPS_LOCK,
        ScrollLock = GLFWConstants.GLFW_KEY_SCROLL_LOCK,
        Pause = GLFWConstants.GLFW_KEY_PAUSE,
        Menu = GLFWConstants.GLFW_KEY_MENU,

        // function keys
        Function1 = GLFWConstants.GLFW_KEY_F1,
        Function2 = GLFWConstants.GLFW_KEY_F2,
        Function3 = GLFWConstants.GLFW_KEY_F3,
        Function4 = GLFWConstants.GLFW_KEY_F4,
        Function5 = GLFWConstants.GLFW_KEY_F5,
        Function6 = GLFWConstants.GLFW_KEY_F6,
        Function7 = GLFWConstants.GLFW_KEY_F7,
        Function8 = GLFWConstants.GLFW_KEY_F8,
        Function9 = GLFWConstants.GLFW_KEY_F9,
        Function10 = GLFWConstants.GLFW_KEY_F10,
        Function11 = GLFWConstants.GLFW_KEY_F11,
        Function12 = GLFWConstants.GLFW_KEY_F12,
        Function13 = GLFWConstants.GLFW_KEY_F13,
        Function14 = GLFWConstants.GLFW_KEY_F14,
        Function15 = GLFWConstants.GLFW_KEY_F15,
        Function16 = GLFWConstants.GLFW_KEY_F16,
        Function17 = GLFWConstants.GLFW_KEY_F17,
        Function18 = GLFWConstants.GLFW_KEY_F18,
        Function19 = GLFWConstants.GLFW_KEY_F19,
        Function20 = GLFWConstants.GLFW_KEY_F20,
        Function21 = GLFWConstants.GLFW_KEY_F21,
        Function22 = GLFWConstants.GLFW_KEY_F22,
        Function23 = GLFWConstants.GLFW_KEY_F23,
        Function24 = GLFWConstants.GLFW_KEY_F24,
        Function25 = GLFWConstants.GLFW_KEY_F25,

        A = 'A',
        B = 'B',
        C = 'C',
        D = 'D',
        E = 'E',
        F = 'F',
        G = 'G',
        H = 'H',
        I = 'I',
        J = 'J',
        K = 'K',
        L = 'L',
        M = 'M',
        N = 'N',
        O = 'O',
        P = 'P',
        Q = 'Q',
        R = 'R',
        S = 'S',
        T = 'T',
        U = 'U',
        V = 'V',
        W = 'W',
        X = 'X',
        Y = 'Y',
        Z = 'Z',
        Æ = 'Æ',
        Ø = 'Ø',
        Å = 'Å',

    }
}
