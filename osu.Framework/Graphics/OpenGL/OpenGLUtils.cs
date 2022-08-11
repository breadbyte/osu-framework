// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Graphics.Rendering;
using osuTK.Graphics.ES30;

namespace osu.Framework.Graphics.OpenGL
{
    internal static class OpenGLUtils
    {
        public static PrimitiveType ToPrimitiveType(PrimitiveTopology topology)
        {
            switch (topology)
            {
                case PrimitiveTopology.Points:
                    return PrimitiveType.Points;

                case PrimitiveTopology.Lines:
                    return PrimitiveType.Lines;

                case PrimitiveTopology.LineStrip:
                    return PrimitiveType.LineStrip;

                case PrimitiveTopology.Triangles:
                    return PrimitiveType.Triangles;

                case PrimitiveTopology.TriangleStrip:
                    return PrimitiveType.TriangleStrip;

                default:
                    throw new ArgumentException($"Unsupported vertex topology: {topology}.", nameof(topology));
            }
        }

        public static DepthFunction ToDepthFunction(DepthTestFunction depthTestFunction)
        {
            switch (depthTestFunction)
            {
                case DepthTestFunction.Never:
                    return DepthFunction.Never;

                case DepthTestFunction.LessThan:
                    return DepthFunction.Less;

                case DepthTestFunction.LessThanOrEqual:
                    return DepthFunction.Lequal;

                case DepthTestFunction.Equal:
                    return DepthFunction.Equal;

                case DepthTestFunction.GreaterThanOrEqual:
                    return DepthFunction.Gequal;

                case DepthTestFunction.Greater:
                    return DepthFunction.Greater;

                case DepthTestFunction.NotEqual:
                    return DepthFunction.Notequal;

                case DepthTestFunction.Always:
                    return DepthFunction.Always;

                default:
                    throw new ArgumentException($"Unsupported depth test function: {depthTestFunction}.", nameof(depthTestFunction));
            }
        }
    }
}
