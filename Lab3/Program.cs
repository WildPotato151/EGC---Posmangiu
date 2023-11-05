using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.IO;
using System.Collections.Generic;

namespace Lab3
{
    class Program : GameWindow
    {
        private float angle = 0.0f;
        private Vector3 triangleColor = Vector3.Zero;

        private Vector3 minColor = new Vector3(0.0f, 0.0f, 0.0f);
        private Vector3 maxColor = new Vector3(1.0f, 1.0f, 1.0f);

        private bool isMouseLeftButtonDown = false;
        private bool isMouseRightButtonDown = false;
        private Vector2 lastMousePosition;



        private List<Vector3> triangleVertices = new List<Vector3>();

        public Program() : base(800, 600, GraphicsMode.Default, "Tema L3 - Posmangiu Ionut 3133a")
        {
            VSync = VSyncMode.On;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            string[] lines = File.ReadAllLines("coord_triunghi.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                if (parts.Length == 3)
                {
                    float x = float.Parse(parts[0]);
                    float y = float.Parse(parts[1]);
                    float z = float.Parse(parts[2]);
                    triangleVertices.Add(new Vector3(x, y, z));
                }
            }

            triangleColor = new Vector3(1.0f, 0.0f, 0.0f);
            GL.ClearColor(Color4.White);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            var keyboard = Keyboard.GetState();
            var mouse = Mouse.GetState();

            if (keyboard.IsKeyDown(Key.Escape))
            {
                Exit();
            }

            if (keyboard.IsKeyDown(Key.R))
            {
                triangleColor.X = MathHelper.Clamp(triangleColor.X + 0.01f, minColor.X, maxColor.X);
            }
            if (keyboard.IsKeyDown(Key.G))
            {
                triangleColor.Y = MathHelper.Clamp(triangleColor.Y + 0.01f, minColor.Y, maxColor.Y);
            }
            if (keyboard.IsKeyDown(Key.B))
            {
                triangleColor.Z = MathHelper.Clamp(triangleColor.Z + 0.01f, minColor.Z, maxColor.Z);
            }

            if (isMouseLeftButtonDown)
            {
                float deltaX = mouse.X - lastMousePosition.X;
                angle += deltaX * 0.01f;
            }

            if (isMouseRightButtonDown)
            {
                float deltaY = mouse.Y - lastMousePosition.Y;
                angle += deltaY * 0.01f;
            }

            lastMousePosition = new Vector2(mouse.X, mouse.Y);

            if (mouse.IsButtonDown(MouseButton.Left))
            {
                isMouseLeftButtonDown = true;
            }
            else
            {
                isMouseLeftButtonDown = false;
            }

            if (mouse.IsButtonDown(MouseButton.Right))
            {
                isMouseRightButtonDown = true;
            }
            else
            {
                isMouseRightButtonDown = false;
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Rotate(angle, Vector3.UnitZ);

            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(triangleColor);

            foreach (Vector3 vertex in triangleVertices)
            {
                GL.Vertex3(vertex);
            }

            GL.End();



            SwapBuffers();
        }

        static void Main(string[] args)
        {
            using (Program program = new Program())
            {
                Console.WriteLine(" Tema L3 - Posmangiu Ionut 3133a\n\n R - red\n G - green\n B - blue\n Mouse click - rotate angle");
                program.Run(60.0);

            }
        }
    }
}
