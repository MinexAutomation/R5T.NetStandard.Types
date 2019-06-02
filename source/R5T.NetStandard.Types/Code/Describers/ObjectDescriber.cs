﻿using System;


namespace R5T.NetStandard
{
    /// <summary>
    /// Describes both the type and value of an object.
    /// </summary>
    public class ObjectDescriber : IDescriber
    {
        #region Static

        /// <summary>
        /// Deafult uses <see cref="NetStandard.TypeDescriber.Instance"/> and <see cref="Describer.Default"/>.
        /// </summary>
        public static readonly ObjectDescriber Default = new ObjectDescriber();

        #endregion


        private IDescriber<Type> TypeDescriber { get; set; }
        private IDescriber ValueDescriber { get; set; }


        public ObjectDescriber(IDescriber<Type> typeDescriber, IDescriber valueDescriber)
        {
            this.TypeDescriber = typeDescriber;
            this.ValueDescriber = valueDescriber;
        }

        public ObjectDescriber()
            : this(NetStandard.TypeDescriber.Instance, Describer.Default)
        {
        }

        public string Describe(object obj)
        {
            var objType = obj.GetType();

            var typeDescription = this.TypeDescriber.Describe(objType);
            var valueDescription = this.ValueDescriber.Describe(obj);

            var description = $"[{typeDescription}]:{valueDescription}";
            return description;
        }
    }
}
