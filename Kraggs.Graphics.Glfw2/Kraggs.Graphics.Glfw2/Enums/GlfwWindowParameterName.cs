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
    public enum GlfwWindowParameterName
    {
        IsOpened = GLFWConstants.GLFW_OPENED,
        IsActive = GLFWConstants.GLFW_ACTIVE,
        IsIconified = GLFWConstants.GLFW_ICONIFIED,
        IsHardwareAccelerated = GLFWConstants.GLFW_ACCELERATED,
        RedBits = GLFWConstants.GLFW_RED_BITS,
        GreenBits = GLFWConstants.GLFW_GREEN_BITS,
        BlueBits = GLFWConstants.GLFW_BLUE_BITS,
        AlphaBits = GLFWConstants.GLFW_ALPHA_BITS,
        DepthBits = GLFWConstants.GLFW_DEPTH_BITS,
        StencilBits = GLFWConstants.GLFW_STENCIL_BITS,

        RefreshRate = GLFWConstants.GLFW_REFRESH_RATE,
        AccumRedBits = GLFWConstants.GLFW_ACCUM_RED_BITS,
        AccumGreenBits = GLFWConstants.GLFW_ACCUM_GREEN_BITS,
        AccumBlueBits = GLFWConstants.GLFW_ACCUM_BLUE_BITS,
        AccumAlphaBits = GLFWConstants.GLFW_ACCUM_ALPHA_BITS,
        AuxBuffers = GLFWConstants.GLFW_AUX_BUFFERS,
        Stereo = GLFWConstants.GLFW_STEREO,
        NoResizeWindow = GLFWConstants.GLFW_WINDOW_NO_RESIZE,
        FSAASamples = GLFWConstants.GLFW_FSAA_SAMPLES,
        OpenGLVersionMajor = GLFWConstants.GLFW_OPENGL_VERSION_MAJOR,
        OpenGLVersionMinor = GLFWConstants.GLFW_OPENGL_VERSION_MINOR,
        OpenGLForwaredCompatible = GLFWConstants.GLFW_OPENGL_FORWARD_COMPAT,
        OpenGLDebugContext = GLFWConstants.GLFW_OPENGL_DEBUG_CONTEXT,
        OpenGLProfile = GLFWConstants.GLFW_OPENGL_PROFILE,

    }
}
