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

using System.Runtime.InteropServices;
using System.Security;


namespace Kraggs.Graphics.Glfw2
{
    public class glfw2
    {
        internal const string GLFW_LIBRARY = "glfw.dll";
        internal const CallingConvention CALL_LIBRARY = CallingConvention.Winapi;

        #region GLFW Callbacks

        public delegate int delWindowCloseCallback();
        public delegate void delWindowResizeCallback(int Width, int Height);
        public delegate void delWindowRefreshCallback();

        public delegate void delWindowKeyCallback(GlfwKeys key, GlfwActionState action);
        public delegate void delWindowCharCallback(int UnicodeChar, GlfwActionState action);
        public delegate void delMouseButtonCallback(GlfwMouseButton button, GlfwActionState action);
        public delegate void delMousePositionCallback(int x, int y);
        public delegate void delMouseWheelCallback(int pos);

        #endregion

        #region 3.1 GLFW Initialization and Termination

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwInit", CallingConvention = CALL_LIBRARY)]
        public static extern int Init();

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwTerminate", CallingConvention = CALL_LIBRARY)]
        public static extern void Terminate();

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetVersion", CallingConvention = CALL_LIBRARY)]
        public static extern void GetVersion(out int major, out int minor, out int rev);

        #endregion

        #region 3.2 Window Handling

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwOpenWindow", CallingConvention = CALL_LIBRARY)]
        public static extern int OpenWindow(int width, int height, int redbits, int greenbits, int bluebits, int alphabits, int depthbits, int stencilbits, GlfwWindowMode mode);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwOpenWindowHint", CallingConvention = CALL_LIBRARY)]
        public static extern void OpenWindowHint(GlfwHintTarget target, int hint);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwCloseWindow", CallingConvention = CALL_LIBRARY)]
        public static extern void CloseWindow();

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetWindowCloseCallback", CallingConvention = CALL_LIBRARY)]
        public static extern void SetWindowCloseCallback(delWindowCloseCallback cbfun);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetWindowTitle", CallingConvention = CALL_LIBRARY)]
        public static extern void SetWindowTitle(string Title);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetWindowSize", CallingConvention = CALL_LIBRARY)]
        public static extern void SetWindowSize(int width, int height);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetWindowPos", CallingConvention = CALL_LIBRARY)]
        public static extern void SetWindowPos(int x, int y);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetWindowSize", CallingConvention = CALL_LIBRARY)]
        public static extern void GetWindowSize(out int width, out int height);


        //[DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetWindowPos", CallingConvention = CALL_LIBRARY)]
        //public static extern void GetWindowPos(out int x, out int y);


        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetWindowSizeCallback", CallingConvention = CALL_LIBRARY)]
        public static extern void SetWindowSizeCallback(delWindowResizeCallback cbfun);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwIconifyWindow", CallingConvention = CALL_LIBRARY)]
        public static extern void IconifyWindow();

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwRestoreWindow", CallingConvention = CALL_LIBRARY)]
        public static extern void RestoreWindow();

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetWindowParam", CallingConvention = CALL_LIBRARY)]
        public static extern int GetWindowParam(GlfwWindowParameterName PName);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSwapBuffers", CallingConvention = CALL_LIBRARY)]
        public static extern void SwapBuffers();

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSwapInterval", CallingConvention = CALL_LIBRARY)]
        public static extern void SwapInterval(int interval);
        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetWindowRefreshCallback", CallingConvention = CALL_LIBRARY)]
        public static extern void SetWindowRefreshCallback(delWindowRefreshCallback cbfun);

        #endregion

        #region 3.3 Video Modes

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetVideoModes", CallingConvention = CALL_LIBRARY)]
        public static extern void GetVideoModes(out GLFWvidmode[] list, int maxCount);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetDesktopMode", CallingConvention = CALL_LIBRARY)]
        public static extern void GetDesktopMode(out GLFWvidmode mode);


        #endregion

        #region 3.4 Input Handling

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwPollEvents", CallingConvention = CALL_LIBRARY)]
        public static extern void PollEvents();

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwWaitEvents", CallingConvention = CALL_LIBRARY)]
        public static extern void WaitEvents();

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetKey", CallingConvention = CALL_LIBRARY)]
        public static extern GlfwActionState GetKey(GlfwKeys key);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetMouseButton", CallingConvention = CALL_LIBRARY)]
        public static extern int GetMouseButton(GlfwMouseButton button);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetMousePos", CallingConvention = CALL_LIBRARY)]
        public static extern void GetMousePosition(out int xpos, out int ypos);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetMousePos", CallingConvention = CALL_LIBRARY)]
        public static extern void GetMousePosition(int xpos, int ypos);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetMouseWheel", CallingConvention = CALL_LIBRARY)]
        public static extern int GetMouseWheel();

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetMouseWheel", CallingConvention = CALL_LIBRARY)]
        public static extern void SetMouseWheel(int pos);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetKeyCallback", CallingConvention = CALL_LIBRARY)]
        public static extern void SetKeyCallback(delWindowKeyCallback cbfun);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetCharCallback", CallingConvention = CALL_LIBRARY)]
        public static extern void SetCharCallback(delWindowCharCallback cbfun);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetMouseButtonCallback", CallingConvention = CALL_LIBRARY)]
        public static extern void SetMouseButtonCallback(delMouseButtonCallback cbfun);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetMousePosCallback", CallingConvention = CALL_LIBRARY)]
        public static extern void SetMousePositionCallback(delMousePositionCallback cbfun);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwSetMouseWheelCallback", CallingConvention = CALL_LIBRARY)]
        public static extern void SetMouseWheelCallback(delMouseWheelCallback cbfun);

        //[DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetJoystickParam", CallingConvention = CALL_LIBRARY)]
        //public static extern void GetJoystickParam(int joy, int param);

        #endregion

        #region 3.5 Timing

        // obsolete

        #endregion

        #region 3.6 Image and Texture Loading

        // obsolete

        #endregion

        #region 3.7 OpenGL Extension Support

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwExtensionSupported", CallingConvention = CALL_LIBRARY)]
        public static extern int ExtensionSupported(string extName);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetProcAddress", CallingConvention = CALL_LIBRARY)]
        public static extern IntPtr GetProcAddress(string procName);

        [Obsolete("Removed from glfw 3.x")]
        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetGLVersion", CallingConvention = CALL_LIBRARY)]
        public static extern void GetOpenGLVersion(out int major, out int minor, out int rev);

        #endregion

        #region 3.8 Threads

        // obsolete

        #endregion

        #region 3.9 Mutexes

        // obsolete

        #endregion

        #region 3.10 Condition Variables

        // obsolete

        #endregion

        #region 3.11 Miscellaneous

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwEnable", CallingConvention = CALL_LIBRARY)]
        public static extern void Enable(GlfwOptions cap);

        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwDisable", CallingConvention = CALL_LIBRARY)]
        public static extern void Disable(GlfwOptions cap);

        //removed from glfw 3.x
        [Obsolete("Removed from glfw 3.x")]  
        [DllImport(GLFW_LIBRARY, EntryPoint = "glfwGetNumberOfProcessors", CallingConvention = CALL_LIBRARY)]
        public static extern int GetNumberOfProcessors();

        #endregion

    }
}
