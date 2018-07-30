#region |=======================INFORMATION=========================|
/* 
 *                              Accessibility
 *   
 *      All types and type members have an accessibility level, 
 *      which controls whether they can be used from other code
 *      in your assembly or other assemblies. [ref.1]
 *      
 *      This document contains some basic examples of accessibility
 *      for more information head over to the accessibility Project.
 *      
 *      If you are looking for polymorphism accessibility, please
 *      go check out the polymorphism project.
 *  
 * 
 */
#endregion

#region |=========================LICENCE===========================|
/* 
*       Document Created By: 
*       Lachlan van der Velden 
*       (mailto:me@lachlanvelden.com) (https://lachlanvelden.com)
*       
*       Do not distribute any source from this solution, in its entirety
*       or separated without explicit permission from the document creator.  
*       permission is granted by a friendly email request.
* 
*       Thank you for your understanding. 
*/
#endregion


using System;

namespace OOP.Summary.General
{
    class Properties
    {

        /// <summary>
        /// - Accessible globally
        /// - Allows all code access to get and set this property.
        /// </summary>
        public int IntegerProperty { get; set; }

        /// <summary>
        /// - Accessible globally
        /// - Allows all code access to get the value of this property.
        /// - Denys all code except the current object to setting this property
        /// </summary>
        public int IntegerPropertyPrivateSet { get; private set; }

        /// <summary>
        /// - Accessible globally
        /// - Allows all other code access to get the value of this property.
        /// - Denys all code except the current object to setting this property
        /// </summary>
        public int IntegerPropertyPrivateGet { private get; set; }

        /// <summary>
        /// - Only Accessible from the same project / assembly
        /// - Allows all code within the current assembly / project to get and set this property.
        /// </summary>
        internal int InternalIntegerProperty { get; set; }

        /// <summary>
        /// - Only Accessible from the same project / assembly
        /// - Allows all code within the current assembly / project to get this property.
        /// - Denys all code except the current object to setting this property
        /// </summary>
        internal int InternalIntegerPropertyPrivateSet { get; private set; }

    }


    class MethodsAndFunctions
    {

        /// <summary>
        /// - Accessible globally
        /// </summary>
        public void PublicMethod() { }

        /// <summary>
        /// - Accessible from the same project / assembly
        /// </summary>
        internal void InternalMethod() { }

        /// <summary>
        /// - Accessible from the same object, or any overrides (see more in the Accessibility project)
        /// </summary>
        protected void ProtectedMethod() { }

        /// <summary>
        /// - Accessible from only the same object
        /// </summary>
        private void PrivateMethod() { }


        /// <summary>
        /// - Accessible globally
        /// </summary>
        public int PublicFunction() { return 0; }

        /// <summary>
        /// - Accessible from the same project / assembly
        /// </summary>
        internal int InternalFunction() { return 0; }

        /// <summary>
        /// - Accessible from the same object, or any overrides (see more in the Accessibility project)
        /// </summary>
        protected int ProtectedFunction() { return 0; }

        /// <summary>
        /// - Accessible from only the same object
        /// </summary>
        private int PrivateFunction() { return 0; }

    }

    class Fields
    {

        /// <summary>
        /// - Accessible globally
        /// </summary>
        public int PublicIntegerField;

        /// <summary>
        /// - Accessible from the same project / assembly
        /// </summary>
        internal int InternalIntegerField;

        /// <summary>
        /// - Accessible from the same object, or any overrides (see more in the Accessibility project)
        /// </summary>
        protected int ProtectedIntegerField;

        /// <summary>
        /// - Accessible from only the same object
        /// </summary>
        private int PrivateIntegerField;

    }
}