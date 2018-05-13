using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EML.NumericTypes;
using EML.Sets;
using EML.Tools;
using EML.Exceptions;
using EML.Extensions;

namespace EML
{
    /// <summary>Represents a complex number.</summary>
    /// <typeparam name="T">The type of number to use for the value of the complex number.</typeparam>
    public class Complex<T> where T : class
    {
        public static readonly Type[] acceptableTypes = { typeof(byte), typeof(short), typeof(int), typeof(long), typeof(sbyte), typeof(ushort), typeof(uint), typeof(ulong), typeof(float), typeof(double), typeof(decimal), typeof(LargeInteger), typeof(LargeDecimal) };
        /// <summary>The real part of the complex number.</summary>
        public T RealPart { get; set; }
        /// <summary>The imaginary part of the complex number.</summary>
        public T ImaginaryPart { get; set; }

        public Complex(T real, T imaginary)
        {
            if (acceptableTypes.Contains(typeof(T)))
            {
                RealPart = real;
                ImaginaryPart = imaginary;
            }
        }

        // Implement addition, subtraction, etc.
        public static Complex<T> operator +(Complex<T> left, Complex<T> right)
        {
            Complex<T> result = new Complex<T>(default(T), default(T))
            {
                RealPart = Addition(left.RealPart, right.RealPart),
                ImaginaryPart = Addition(left.ImaginaryPart, right.ImaginaryPart)
            };
            return result;
        }
        public static Complex<T> operator -(Complex<T> left, Complex<T> right)
        {
            Complex<T> result = new Complex<T>(default(T), default(T))
            {
                RealPart = Subtraction(left.RealPart, right.RealPart),
                ImaginaryPart = Subtraction(left.ImaginaryPart, right.ImaginaryPart)
            };
            return result;
        }
        public static Complex<T> operator *(Complex<T> left, Complex<T> right)
        {
            Complex<T> result = new Complex<T>(default(T), default(T))
            {
                RealPart = Multiplication(left.RealPart, right.RealPart),
                ImaginaryPart = Multiplication(left.ImaginaryPart, right.ImaginaryPart)
            };
            return result;
        }
        public static Complex<T> operator /(Complex<T> left, Complex<T> right)
        {
            Complex<T> result = new Complex<T>(default(T), default(T))
            {
                RealPart = Division(left.RealPart, right.RealPart),
                ImaginaryPart = Division(left.ImaginaryPart, right.ImaginaryPart)
            };
            return result;
        }

        public static T Addition(T left, T right)
        {
            if (typeof(T) == typeof(int))
                return ((left as int?) + (right as int?)) as T;
            else if (typeof(T) == typeof(long))
                return ((left as long?) + (right as long?)) as T;
            else if (typeof(T) == typeof(short))
                return ((left as short?) + (right as short?)) as T;
            else if (typeof(T) == typeof(byte))
                return ((left as byte?) + (right as byte?)) as T;
            else if (typeof(T) == typeof(uint))
                return ((left as uint?) + (right as uint?)) as T;
            else if (typeof(T) == typeof(ulong))
                return ((left as ulong?) + (right as ulong?)) as T;
            else if (typeof(T) == typeof(ushort))
                return ((left as ushort?) + (right as ushort?)) as T;
            else if (typeof(T) == typeof(sbyte))
                return ((left as sbyte?) + (right as sbyte?)) as T;
            else if (typeof(T) == typeof(float))
                return ((left as float?) + (right as float?)) as T;
            else if (typeof(T) == typeof(double))
                return ((left as double?) + (right as double?)) as T;
            else if (typeof(T) == typeof(decimal))
                return ((left as decimal?) + (right as decimal?)) as T;
            else if (typeof(T) == typeof(LargeInteger))
                return ((left as decimal?) + (right as decimal?)) as T;
            else if (typeof(T) == typeof(LargeDecimal))
                return ((left as decimal?) + (right as decimal?)) as T;
            else
                throw new Exception("The provided argument is not a valid numerical type.");
        }
        public static T Subtraction(T left, T right)
        {
            if (typeof(T) == typeof(int))
                return ((left as int?) - (right as int?)) as T;
            else if (typeof(T) == typeof(long))
                return ((left as long?) - (right as long?)) as T;
            else if (typeof(T) == typeof(short))
                return ((left as short?) - (right as short?)) as T;
            else if (typeof(T) == typeof(byte))
                return ((left as byte?) - (right as byte?)) as T;
            else if (typeof(T) == typeof(uint))
                return ((left as uint?) - (right as uint?)) as T;
            else if (typeof(T) == typeof(ulong))
                return ((left as ulong?) - (right as ulong?)) as T;
            else if (typeof(T) == typeof(ushort))
                return ((left as ushort?) - (right as ushort?)) as T;
            else if (typeof(T) == typeof(sbyte))
                return ((left as sbyte?) - (right as sbyte?)) as T;
            else if (typeof(T) == typeof(float))
                return ((left as float?) - (right as float?)) as T;
            else if (typeof(T) == typeof(double))
                return ((left as double?) - (right as double?)) as T;
            else if (typeof(T) == typeof(decimal))
                return ((left as decimal?) - (right as decimal?)) as T;
            else if (typeof(T) == typeof(LargeInteger))
                return ((left as decimal?) - (right as decimal?)) as T;
            else if (typeof(T) == typeof(LargeDecimal))
                return ((left as decimal?) - (right as decimal?)) as T;
            else
                throw new Exception("The provided argument is not a valid numerical type.");
        }
        public static T Multiplication(T left, T right)
        {
            if (typeof(T) == typeof(int))
                return ((left as int?) * (right as int?)) as T;
            else if (typeof(T) == typeof(long))
                return ((left as long?) * (right as long?)) as T;
            else if (typeof(T) == typeof(short))
                return ((left as short?) * (right as short?)) as T;
            else if (typeof(T) == typeof(byte))
                return ((left as byte?) * (right as byte?)) as T;
            else if (typeof(T) == typeof(uint))
                return ((left as uint?) * (right as uint?)) as T;
            else if (typeof(T) == typeof(ulong))
                return ((left as ulong?) * (right as ulong?)) as T;
            else if (typeof(T) == typeof(ushort))
                return ((left as ushort?) * (right as ushort?)) as T;
            else if (typeof(T) == typeof(sbyte))
                return ((left as sbyte?) * (right as sbyte?)) as T;
            else if (typeof(T) == typeof(float))
                return ((left as float?) * (right as float?)) as T;
            else if (typeof(T) == typeof(double))
                return ((left as double?) * (right as double?)) as T;
            else if (typeof(T) == typeof(decimal))
                return ((left as decimal?) * (right as decimal?)) as T;
            else if (typeof(T) == typeof(LargeInteger))
                return ((left as decimal?) * (right as decimal?)) as T;
            else if (typeof(T) == typeof(LargeDecimal))
                return ((left as decimal?) * (right as decimal?)) as T;
            else
                throw new Exception("The provided argument is not a valid numerical type.");
        }
        public static T Division(T left, T right)
        {
            if (typeof(T) == typeof(int))
                return ((left as int?) / (right as int?)) as T;
            else if (typeof(T) == typeof(long))
                return ((left as long?) / (right as long?)) as T;
            else if (typeof(T) == typeof(short))
                return ((left as short?) / (right as short?)) as T;
            else if (typeof(T) == typeof(byte))
                return ((left as byte?) / (right as byte?)) as T;
            else if (typeof(T) == typeof(uint))
                return ((left as uint?) / (right as uint?)) as T;
            else if (typeof(T) == typeof(ulong))
                return ((left as ulong?) / (right as ulong?)) as T;
            else if (typeof(T) == typeof(ushort))
                return ((left as ushort?) / (right as ushort?)) as T;
            else if (typeof(T) == typeof(sbyte))
                return ((left as sbyte?) / (right as sbyte?)) as T;
            else if (typeof(T) == typeof(float))
                return ((left as float?) / (right as float?)) as T;
            else if (typeof(T) == typeof(double))
                return ((left as double?) / (right as double?)) as T;
            else if (typeof(T) == typeof(decimal))
                return ((left as decimal?) / (right as decimal?)) as T;
            else if (typeof(T) == typeof(LargeInteger))
                return ((left as decimal?) / (right as decimal?)) as T;
            else if (typeof(T) == typeof(LargeDecimal))
                return ((left as decimal?) / (right as decimal?)) as T;
            else
                throw new Exception("The provided argument is not a valid numerical type.");
        }
    }
}