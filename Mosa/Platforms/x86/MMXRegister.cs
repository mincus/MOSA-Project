/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Michael Ruck (<mailto:sharpos@michaelruck.de>)
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Mosa.Platforms.x86
{
    /// <summary>
    /// Represents an MMX register.
    /// </summary>
    public sealed class MMXRegister : GenericX86Register
    {
        #region Static data members

        /// <summary>
        /// Represents the MMX register MM0.
        /// </summary>
        public static readonly MMXRegister MM0 = new MMXRegister(0);

        /// <summary>
        /// Represents the MMX register MM1.
        /// </summary>
        public static readonly MMXRegister MM1 = new MMXRegister(1);

        /// <summary>
        /// Represents the MMX register MM2.
        /// </summary>
        public static readonly MMXRegister MM2 = new MMXRegister(2);

        /// <summary>
        /// Represents the MMX register MM3.
        /// </summary>
        public static readonly MMXRegister MM3 = new MMXRegister(3);

        /// <summary>
        /// Represents the MMX register MM4.
        /// </summary>
        public static readonly MMXRegister MM4 = new MMXRegister(4);

        /// <summary>
        /// Represents the MMX register MM5.
        /// </summary>
        public static readonly MMXRegister MM5 = new MMXRegister(5);

        /// <summary>
        /// Represents the MMX register MM6.
        /// </summary>
        public static readonly MMXRegister MM6 = new MMXRegister(6);

        /// <summary>
        /// Represents the MMX register MM7.
        /// </summary>
        public static readonly MMXRegister MM7 = new MMXRegister(7);

        #endregion // Static data members

        #region Data members

        /// <summary>
        /// The register index.
        /// </summary>
        private int _registerCode;

        #endregion // Data members

        #region Construction

        /// <summary>
        /// Initializes a new instance of the MMX register.
        /// </summary>
        /// <param name="registerCode">The MMX register index.</param>
        private MMXRegister(int registerCode)
        {
            _registerCode = registerCode;
        }

        #endregion // Construction

        #region Properties

        /// <summary>
        /// MMX registers do not support fp operation.
        /// </summary>
        public override bool IsFloatingPoint
        {
            get { return false; }
        }

        /// <summary>
        /// Retrieves the register index.
        /// </summary>
        public override int RegisterCode
        {
            get { return _registerCode; }
        }

        /// <summary>
        /// Returns the width of MMX registers.
        /// </summary>
        public override int Width
        {
            get { return 64; }
        }

        #endregion // Properties

        #region Methods

        /// <summary>
        /// Returns the string representation of the register.
        /// </summary>
        /// <returns>The string representation of the register.</returns>
        public override string ToString()
        {
            return String.Format("MM{0}", _registerCode);
        }

        #endregion // Methods
    }
}