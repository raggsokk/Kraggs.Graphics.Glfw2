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
    internal static partial class GLFWConstants
    {
        /*************************************************************************
        * GLFW version
        *************************************************************************/

        public const int GLFW_VERSION_MAJOR    = 2;
        public const int GLFW_VERSION_MINOR    = 7;
        public const int GLFW_VERSION_REVISION  = 7;


        /*************************************************************************
        * Input handling definitions
        *************************************************************************/

        /* Key and button state/action definitions */
        public const int GLFW_RELEASE            = 0;
        public const int GLFW_PRESS              = 1;

        /* Keyboard key definitions: 8-bit ISO-8859-1 (Latin 1) encoding is used
        * for printable keys (such as A-Z; 0-9 etc); and values above 256
        * represent special (non-printable) keys (e.g. F1; Page Up etc).
        */

        public const int GLFW_KEY_UNKNOWN      = -1;
        public const int GLFW_KEY_SPACE        = 32;
        public const int GLFW_KEY_SPECIAL      = 256;
        public const int GLFW_KEY_ESC          = (GLFW_KEY_SPECIAL+1);
        public const int GLFW_KEY_F1           = (GLFW_KEY_SPECIAL+2);
        public const int GLFW_KEY_F2           = (GLFW_KEY_SPECIAL+3);
        public const int GLFW_KEY_F3           = (GLFW_KEY_SPECIAL+4);
        public const int GLFW_KEY_F4           = (GLFW_KEY_SPECIAL+5);
        public const int GLFW_KEY_F5           = (GLFW_KEY_SPECIAL+6);
        public const int GLFW_KEY_F6           = (GLFW_KEY_SPECIAL+7);
        public const int GLFW_KEY_F7           = (GLFW_KEY_SPECIAL+8);
        public const int GLFW_KEY_F8           = (GLFW_KEY_SPECIAL+9);
        public const int GLFW_KEY_F9           = (GLFW_KEY_SPECIAL+10);
        public const int GLFW_KEY_F10          = (GLFW_KEY_SPECIAL+11);
        public const int GLFW_KEY_F11          = (GLFW_KEY_SPECIAL+12);
        public const int GLFW_KEY_F12          = (GLFW_KEY_SPECIAL+13);
        public const int GLFW_KEY_F13          = (GLFW_KEY_SPECIAL+14);
        public const int GLFW_KEY_F14          = (GLFW_KEY_SPECIAL+15);
        public const int GLFW_KEY_F15          = (GLFW_KEY_SPECIAL+16);
        public const int GLFW_KEY_F16          = (GLFW_KEY_SPECIAL+17);
        public const int GLFW_KEY_F17          = (GLFW_KEY_SPECIAL+18);
        public const int GLFW_KEY_F18          = (GLFW_KEY_SPECIAL+19);
        public const int GLFW_KEY_F19          = (GLFW_KEY_SPECIAL+20);
        public const int GLFW_KEY_F20          = (GLFW_KEY_SPECIAL+21);
        public const int GLFW_KEY_F21          = (GLFW_KEY_SPECIAL+22);
        public const int GLFW_KEY_F22          = (GLFW_KEY_SPECIAL+23);
        public const int GLFW_KEY_F23          = (GLFW_KEY_SPECIAL+24);
        public const int GLFW_KEY_F24          = (GLFW_KEY_SPECIAL+25);
        public const int GLFW_KEY_F25          = (GLFW_KEY_SPECIAL+26);
        public const int GLFW_KEY_UP           = (GLFW_KEY_SPECIAL+27);
        public const int GLFW_KEY_DOWN         = (GLFW_KEY_SPECIAL+28);
        public const int GLFW_KEY_LEFT         = (GLFW_KEY_SPECIAL+29);
        public const int GLFW_KEY_RIGHT        = (GLFW_KEY_SPECIAL+30);
        public const int GLFW_KEY_LSHIFT       = (GLFW_KEY_SPECIAL+31);
        public const int GLFW_KEY_RSHIFT       = (GLFW_KEY_SPECIAL+32);
        public const int GLFW_KEY_LCTRL        = (GLFW_KEY_SPECIAL+33);
        public const int GLFW_KEY_RCTRL        = (GLFW_KEY_SPECIAL+34);
        public const int GLFW_KEY_LALT         = (GLFW_KEY_SPECIAL+35);
        public const int GLFW_KEY_RALT         = (GLFW_KEY_SPECIAL+36);
        public const int GLFW_KEY_TAB          = (GLFW_KEY_SPECIAL+37);
        public const int GLFW_KEY_ENTER        = (GLFW_KEY_SPECIAL+38);
        public const int GLFW_KEY_BACKSPACE    = (GLFW_KEY_SPECIAL+39);
        public const int GLFW_KEY_INSERT       = (GLFW_KEY_SPECIAL+40);
        public const int GLFW_KEY_DEL          = (GLFW_KEY_SPECIAL+41);
        public const int GLFW_KEY_PAGEUP       = (GLFW_KEY_SPECIAL+42);
        public const int GLFW_KEY_PAGEDOWN     = (GLFW_KEY_SPECIAL+43);
        public const int GLFW_KEY_HOME         = (GLFW_KEY_SPECIAL+44);
        public const int GLFW_KEY_END          = (GLFW_KEY_SPECIAL+45);
        public const int GLFW_KEY_KP_0         = (GLFW_KEY_SPECIAL+46);
        public const int GLFW_KEY_KP_1         = (GLFW_KEY_SPECIAL+47);
        public const int GLFW_KEY_KP_2         = (GLFW_KEY_SPECIAL+48);
        public const int GLFW_KEY_KP_3         = (GLFW_KEY_SPECIAL+49);
        public const int GLFW_KEY_KP_4         = (GLFW_KEY_SPECIAL+50);
        public const int GLFW_KEY_KP_5         = (GLFW_KEY_SPECIAL+51);
        public const int GLFW_KEY_KP_6         = (GLFW_KEY_SPECIAL+52);
        public const int GLFW_KEY_KP_7         = (GLFW_KEY_SPECIAL+53);
        public const int GLFW_KEY_KP_8         = (GLFW_KEY_SPECIAL+54);
        public const int GLFW_KEY_KP_9         = (GLFW_KEY_SPECIAL+55);
        public const int GLFW_KEY_KP_DIVIDE    = (GLFW_KEY_SPECIAL+56);
        public const int GLFW_KEY_KP_MULTIPLY  = (GLFW_KEY_SPECIAL+57);
        public const int GLFW_KEY_KP_SUBTRACT  = (GLFW_KEY_SPECIAL+58);
        public const int GLFW_KEY_KP_ADD       = (GLFW_KEY_SPECIAL+59);
        public const int GLFW_KEY_KP_DECIMAL   = (GLFW_KEY_SPECIAL+60);
        public const int GLFW_KEY_KP_EQUAL     = (GLFW_KEY_SPECIAL+61);
        public const int GLFW_KEY_KP_ENTER     = (GLFW_KEY_SPECIAL+62);
        public const int GLFW_KEY_KP_NUM_LOCK  = (GLFW_KEY_SPECIAL+63);
        public const int GLFW_KEY_CAPS_LOCK    = (GLFW_KEY_SPECIAL+64);
        public const int GLFW_KEY_SCROLL_LOCK  = (GLFW_KEY_SPECIAL+65);
        public const int GLFW_KEY_PAUSE        = (GLFW_KEY_SPECIAL+66);
        public const int GLFW_KEY_LSUPER       = (GLFW_KEY_SPECIAL+67);
        public const int GLFW_KEY_RSUPER       = (GLFW_KEY_SPECIAL+68);
        public const int GLFW_KEY_MENU         = (GLFW_KEY_SPECIAL+69);
        public const int GLFW_KEY_LAST         = GLFW_KEY_MENU;

        /* Mouse button definitions */
        public const int GLFW_MOUSE_BUTTON_1      = 0;
        public const int GLFW_MOUSE_BUTTON_2      = 1;
        public const int GLFW_MOUSE_BUTTON_3      = 2;
        public const int GLFW_MOUSE_BUTTON_4      = 3;
        public const int GLFW_MOUSE_BUTTON_5      = 4;
        public const int GLFW_MOUSE_BUTTON_6      = 5;
        public const int GLFW_MOUSE_BUTTON_7      = 6;
        public const int GLFW_MOUSE_BUTTON_8      = 7;
        public const int GLFW_MOUSE_BUTTON_LAST   = GLFW_MOUSE_BUTTON_8;

        /* Mouse button aliases */
        public const int GLFW_MOUSE_BUTTON_LEFT   = GLFW_MOUSE_BUTTON_1;
        public const int GLFW_MOUSE_BUTTON_RIGHT  = GLFW_MOUSE_BUTTON_2;
        public const int GLFW_MOUSE_BUTTON_MIDDLE = GLFW_MOUSE_BUTTON_3;


        /* Joystick identifiers */
        public const int GLFW_JOYSTICK_1          = 0;
        public const int GLFW_JOYSTICK_2          = 1;
        public const int GLFW_JOYSTICK_3          = 2;
        public const int GLFW_JOYSTICK_4          = 3;
        public const int GLFW_JOYSTICK_5          = 4;
        public const int GLFW_JOYSTICK_6          = 5;
        public const int GLFW_JOYSTICK_7          = 6;
        public const int GLFW_JOYSTICK_8          = 7;
        public const int GLFW_JOYSTICK_9          = 8;
        public const int GLFW_JOYSTICK_10         = 9;
        public const int GLFW_JOYSTICK_11         = 10;
        public const int GLFW_JOYSTICK_12         = 11;
        public const int GLFW_JOYSTICK_13         = 12;
        public const int GLFW_JOYSTICK_14         = 13;
        public const int GLFW_JOYSTICK_15         = 14;
        public const int GLFW_JOYSTICK_16         = 15;
        public const int GLFW_JOYSTICK_LAST = GLFW_JOYSTICK_16;


        /*************************************************************************
        * Other definitions
        *************************************************************************/

        public const int GLFW_WINDOW = 0x00010001;
        public const int GLFW_FULLSCREEN = 0x00010002;

        public const int GLFW_OPENED = 0x00020001;
        public const int GLFW_ACTIVE = 0x00020002;
        public const int GLFW_ICONIFIED = 0x00020003;
        public const int GLFW_ACCELERATED = 0x00020004;
        public const int GLFW_RED_BITS = 0x00020005;
        public const int GLFW_GREEN_BITS = 0x00020006;
        public const int GLFW_BLUE_BITS = 0x00020007;
        public const int GLFW_ALPHA_BITS = 0x00020008;
        public const int GLFW_DEPTH_BITS = 0x00020009;
        public const int GLFW_STENCIL_BITS = 0x0002000A;

        public const int GLFW_REFRESH_RATE = 0x0002000B;
        public const int GLFW_ACCUM_RED_BITS = 0x0002000C;
        public const int GLFW_ACCUM_GREEN_BITS = 0x0002000D;
        public const int GLFW_ACCUM_BLUE_BITS = 0x0002000E;
        public const int GLFW_ACCUM_ALPHA_BITS = 0x0002000F;
        public const int GLFW_AUX_BUFFERS = 0x00020010;
        public const int GLFW_STEREO = 0x00020011;
        public const int GLFW_WINDOW_NO_RESIZE = 0x00020012;
        public const int GLFW_FSAA_SAMPLES = 0x00020013;
        public const int GLFW_OPENGL_VERSION_MAJOR = 0x00020014;
        public const int GLFW_OPENGL_VERSION_MINOR = 0x00020015;
        public const int GLFW_OPENGL_FORWARD_COMPAT = 0x00020016;
        public const int GLFW_OPENGL_DEBUG_CONTEXT = 0x00020017;
        public const int GLFW_OPENGL_PROFILE = 0x00020018;


        /* GLFW_OPENGL_PROFILE tokens */
        public const int GLFW_OPENGL_CORE_PROFILE  = 0x00050001;
        public const int GLFW_OPENGL_COMPAT_PROFILE = 0x00050002;

        /* glfwEnable/glfwDisable tokens */
        public const int GLFW_MOUSE_CURSOR         = 0x00030001;
        public const int GLFW_STICKY_KEYS          = 0x00030002;
        public const int GLFW_STICKY_MOUSE_BUTTONS = 0x00030003;
        public const int GLFW_SYSTEM_KEYS          = 0x00030004;
        public const int GLFW_KEY_REPEAT           = 0x00030005;
        public const int GLFW_AUTO_POLL_EVENTS     = 0x00030006;

        /* glfwWaitThread wait modes */
        public const int GLFW_WAIT                 = 0x00040001;
        public const int GLFW_NOWAIT               = 0x00040002;

        /* glfwGetJoystickParam tokens */
        public const int GLFW_PRESENT              = 0x00050001;
        public const int GLFW_AXES                 = 0x00050002;
        public const int GLFW_BUTTONS              = 0x00050003;

        public const double GLFW_INFINITY = 100000.0;
    }
}
