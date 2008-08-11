﻿/*
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

namespace Mosa.Runtime.Vm
{
    public abstract class RuntimeMember : RuntimeObject, IRuntimeAttributable
    {
        #region Data members

        /// <summary>
        /// Holds the attributes of the member.
        /// </summary>
        private RuntimeAttribute[] _attributes;

        /// <summary>
        /// Specifies the type, that declares the member.
        /// </summary>
        private RuntimeType _declaringType;

        #endregion // Data members

        #region Construction

        /// <summary>
        /// Initializes a new instance of <see cref="RuntimeMember"/>.
        /// </summary>
        /// <param name="token">Holds the token of this runtime metadata.</param>
        /// <param name="declaringType">The declaring type of the member.</param>
        /// <param name="attributes">Holds the attributes of the member.</param>
        protected RuntimeMember(int token, RuntimeType declaringType, RuntimeAttribute[] attributes) :
            base(token)
        {
            _declaringType = declaringType;
            _attributes = attributes;
        }

        #endregion // Construction

        #region Properties

        /// <summary>
        /// Retrieves the declaring type of the member.
        /// </summary>
        public RuntimeType DeclaringType
        {
            get { return _declaringType; }
        }

        #endregion // Properties

        #region IRuntimeAttributable Members

        public RuntimeAttribute[] CustomAttributes
        {
            get
            {
                return _attributes;
            }
        }

        #endregion // IRuntimeAttributable Members
    }
}