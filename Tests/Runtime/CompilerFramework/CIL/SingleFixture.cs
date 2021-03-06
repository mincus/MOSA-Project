﻿using System;
using System.Collections.Generic;
using System.Text;
using Gallio.Framework;
using MbUnit.Framework;
using MbUnit.Framework.ContractVerifiers;

namespace Test.Mosa.Runtime.CompilerFramework.CLI
{
    [TestFixture]
    [Importance(Importance.Critical)]
    [Category(@"Basic types")]
    [Description(@"Tests support for the basic type System.Single")]
    public class SingleFixture : RuntimeFixture
    {
        private readonly ArithmeticInstructionTestRunner<float, float> arithmeticTests = new ArithmeticInstructionTestRunner<float, float>
        {
            ExpectedTypeName = @"float",
            TypeName = @"float",
            IncludeNeg = false
        };

        private readonly ComparisonInstructionTestRunner<float> comparisonTests = new ComparisonInstructionTestRunner<float>
        {
            TypeName = @"float"
        };

        #region Add

        [Row(1.0f, 1.0f)]
        [Row(1.0f, -2.198f)]
        [Row(-1.2f, 2.11f)]
        [Row(0.0f, 0.0f)]
        // (MinValue, X) Cases
        [Row(float.MinValue, 0.0f)]
        [Row(float.MinValue, 1.2f)]
        [Row(float.MinValue, 17.6f)]
        [Row(float.MinValue, 123.1f)]
        [Row(float.MinValue, -0.0f)]
        [Row(float.MinValue, -1.5f)]
        [Row(float.MinValue, -17.99f)]
        [Row(float.MinValue, -123.235f)]
        // (MaxValue, X) Cases
        [Row(float.MaxValue, 0.0f)]
        [Row(float.MaxValue, 1.67f)]
        [Row(float.MaxValue, 17.875f)]
        [Row(float.MaxValue, 123.283f)]
        [Row(float.MaxValue, -0.0f)]
        [Row(float.MaxValue, -1.1497f)]
        [Row(float.MaxValue, -17.12f)]
        [Row(float.MaxValue, -123.34f)]
        // (X, MinValue) Cases
        [Row(0.0f, float.MinValue)]
        [Row(1.2, float.MinValue)]
        [Row(17.4f, float.MinValue)]
        [Row(123.561f, float.MinValue)]
        [Row(-0.0f, float.MinValue)]
        [Row(-1.78f, float.MinValue)]
        [Row(-17.59f, float.MinValue)]
        [Row(-123.41f, float.MinValue)]
        // (X, MaxValue) Cases
        [Row(0.0f, float.MaxValue)]
        [Row(1.00012f, float.MaxValue)]
        [Row(17.094002f, float.MaxValue)]
        [Row(123.001f, float.MaxValue)]
        [Row(-0.0f, float.MaxValue)]
        [Row(-1.045f, float.MaxValue)]
        [Row(-17.0002501f, float.MaxValue)]
        [Row(-123.023f, float.MaxValue)]
        // Extremvaluecases
        [Row(float.MinValue, float.MaxValue)]
        [Row(1.0f, float.NaN)]
        [Row(float.NaN, 1.0f)]
        [Row(1.0f, float.PositiveInfinity)]
        [Row(float.PositiveInfinity, 1.0f)]
        [Row(1.0f, float.NegativeInfinity)]
        [Row(float.NegativeInfinity, 1.0f)]
        [Test, Author("alyman", "mail.alex.lyman@gmail.com")]
        public void Add(float a, float b)
        {
            this.arithmeticTests.Add((float)(a + b), a, b);
        }

        #endregion // Add

        #region Sub

        [Row(1.2f, 2.1f)]
        [Row(23.0f, 21.2578f)]
        [Row(1.0f, -2.198f)]
        [Row(-1.2f, 2.11f)]
        [Row(0.0f, 0.0f)]
        // (MinValue, X) Cases
        [Row(float.MinValue, 0.0f)]
        [Row(float.MinValue, 1.2f)]
        [Row(float.MinValue, 17.6f)]
        [Row(float.MinValue, 123.1f)]
        [Row(float.MinValue, -0.0f)]
        [Row(float.MinValue, -1.5f)]
        [Row(float.MinValue, -17.99f)]
        [Row(float.MinValue, -123.235f)]
        // (MaxValue, X) Cases
        [Row(float.MaxValue, 0.0f)]
        [Row(float.MaxValue, 1.67f)]
        [Row(float.MaxValue, 17.875f)]
        [Row(float.MaxValue, 123.283f)]
        [Row(float.MaxValue, -0.0f)]
        [Row(float.MaxValue, -1.1497f)]
        [Row(float.MaxValue, -17.12f)]
        [Row(float.MaxValue, -123.34f)]
        // (X, MinValue) Cases
        [Row(0.0f, float.MinValue)]
        [Row(1.2, float.MinValue)]
        [Row(17.4f, float.MinValue)]
        [Row(123.561f, float.MinValue)]
        [Row(-0.0f, float.MinValue)]
        [Row(-1.78f, float.MinValue)]
        [Row(-17.59f, float.MinValue)]
        [Row(-123.41f, float.MinValue)]
        // (X, MaxValue) Cases
        [Row(0.0f, float.MaxValue)]
        [Row(1.00012f, float.MaxValue)]
        [Row(17.094002f, float.MaxValue)]
        [Row(123.001f, float.MaxValue)]
        [Row(-0.0f, float.MaxValue)]
        [Row(-1.045f, float.MaxValue)]
        [Row(-17.0002501f, float.MaxValue)]
        [Row(-123.023f, float.MaxValue)]
        // Extremvaluecases
        [Row(1.0f, float.NaN)]
        [Row(float.NaN, 1.0f)]
        [Row(1.0f, float.PositiveInfinity)]
        [Row(float.PositiveInfinity, 1.0f)]
        [Row(1.0f, float.NegativeInfinity)]
        [Row(float.NegativeInfinity, 1.0f)]
        [Test, Author("rootnode", "rootnode@mosa-project.org")]
        public void Sub(float a, float b)
        {
            this.arithmeticTests.Sub((float)(a - b), a, b);
        }

        #endregion // Sub

        #region Mul

        [Row(1.0f, 2.0f)]
        [Row(2.0f, 0.0f)]
        [Row(1.0f, float.NaN)]
        [Row(float.NaN, 1.0f)]
        [Row(1.0f, float.PositiveInfinity)]
        [Row(float.PositiveInfinity, 1.0f)]
        [Row(1.0f, float.NegativeInfinity)]
        [Row(float.NegativeInfinity, 1.0f)]
        [Test, Author("alyman", "mail.alex.lyman@gmail.com")]
        public void Mul(float a, float b)
        {
            this.arithmeticTests.Mul((float)(a * b), a, b);
        }

        #endregion // Mul

        #region Div

        [Row(1.0f, 2.0f)]
        [Row(2.0f, 1.0f)]
        [Row(1.0f, 2.5f)]
        [Row(1.7f, 2.3f)]
        [Row(2.0f, -1.0f)]
        [Row(1.0f, -2.5f)]
        [Row(1.7f, -2.3f)]
        [Row(-2.0f, 1.0f)]
        [Row(-1.0f, 2.5f)]
        [Row(-1.7f, 2.3f)]
        [Row(-2.0f, -1.0f)]
        [Row(-1.0f, -2.5f)]
        [Row(-1.7f, -2.3f)]
        [Row(1.0f, float.NaN)]
        [Row(float.NaN, 1.0f)]
        [Row(1.0f, float.PositiveInfinity)]
        [Row(float.PositiveInfinity, 1.0f)]
        [Row(1.0f, float.NegativeInfinity)]
        [Row(float.NegativeInfinity, 1.0f)]
        [Test, Author("alyman", "mail.alex.lyman@gmail.com")]
        public void Div(float a, float b)
        {
            this.arithmeticTests.Div((float)(a / b), a, b);
        }

        #endregion // Div

        #region Rem

        [Row(3.14f, 2.1f)]
        [Row(3.0f, 2.0f)]
        [Row(10.0f, 6.0f)]
        [Row(-10.0f, 6.0f)]
        [Row(-10.0f, -6.0f)]
        [Row(10.0f, -6.0f)]
        [Test]
        public void Rem(float a, float b)
        {
            this.arithmeticTests.Rem((float)(a % b), a, b);
        }

        #endregion // Rem

        #region Ret

        [Row(0f)]
        [Row(1f)]
        [Row(float.MinValue)]
        [Row(float.MaxValue)]
        [Test, Author(@"Michael Fröhlich, sharpos@michaelruck.de")]
        [Ignore(@"MOSA puts floating point results in XMM#0, where stdcall expects them in FP0 causing this test to fail.")]
        public void Ret(float value)
        {
            this.arithmeticTests.Ret(value);
        }

        #endregion // Ret

        #region Ceq

        [Row(true, 0f, 0f)]
        [Row(false, 0f, 1f)]
        [Row(true, 1f, 1f)]
        [Row(false, 1f, 0f)]
        [Row(true, float.MinValue, float.MinValue)]
        [Row(true, float.MaxValue, float.MaxValue)]
        [Row(false, float.MinValue, float.MaxValue)]
        [Test, Author(@"Michael Fröhlich, sharpos@michaelruck.de")]
        public void Ceq(bool expectedValue, float first, float second)
        {
            this.comparisonTests.Ceq(expectedValue, first, second);
        }

        #endregion // Ceq
    }
}
