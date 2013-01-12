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
    public enum GlfwMouseButton
    {
        Button1 = GLFWConstants.GLFW_MOUSE_BUTTON_1,
        Button2 = GLFWConstants.GLFW_MOUSE_BUTTON_2,
        Button3 = GLFWConstants.GLFW_MOUSE_BUTTON_3,
        Button4 = GLFWConstants.GLFW_MOUSE_BUTTON_4,
        Button5 = GLFWConstants.GLFW_MOUSE_BUTTON_5,
        Button6 = GLFWConstants.GLFW_MOUSE_BUTTON_6,
        Button7 = GLFWConstants.GLFW_MOUSE_BUTTON_7,
        Button8 = GLFWConstants.GLFW_MOUSE_BUTTON_8,

        LastButton = GLFWConstants.GLFW_MOUSE_BUTTON_LAST,

        Left = GLFWConstants.GLFW_MOUSE_BUTTON_LEFT,
        Middle = GLFWConstants.GLFW_MOUSE_BUTTON_MIDDLE,
        Right = GLFWConstants.GLFW_MOUSE_BUTTON_RIGHT,

    }
}
