using System;
using System.Runtime.InteropServices;

namespace SS14.Shared.Maths
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2u : IEquatable<Vector2u>
    {
        /// <summary>
        /// The X component of the Vector2i.
        /// </summary>
        public readonly uint X;

        /// <summary>
        /// The Y component of the Vector2i.
        /// </summary>
        public readonly uint Y;

        /// <summary>
        /// Construct a vector from its coordinates.
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public Vector2u(uint x, uint y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Compare a vector to another vector and check if they are equal.
        /// </summary>
        /// <param name="other">Other vector to check.</param>
        /// <returns>True if the two vectors are equal.</returns>
        public bool Equals(Vector2u other)
        {
            return X == other.X && Y == other.Y;
        }

        /// <summary>
        /// Compare a vector to an object and check if they are equal.
        /// </summary>
        /// <param name="obj">Other object to check.</param>
        /// <returns>True if Object and vector are equal.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Vector2u vec && Equals(vec);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A unique hash code for this instance.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((int)X * 397) ^ (int)Y;
            }
        }

        public static Vector2u operator / (Vector2u vector, uint divider)
        {
            return new Vector2u(vector.X / divider, vector.Y / divider);
        }

        public static implicit operator Vector2(Vector2u vector)
        {
            return new Vector2(vector.X, vector.Y);
        }

        public static explicit operator Vector2u(Vector2 vector)
        {
            return new Vector2u((uint)vector.X, (uint)vector.Y);
        }
    }
}
