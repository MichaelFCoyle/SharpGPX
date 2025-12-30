using System;
using System.Xml.Serialization;

namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class extensionsType
    {
        public extensionsType() { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public extensionsType(extensionsType other) => Any = other?.Any;

        internal void Preserialize() { }

        /// <summary>
        /// The number of extensions
        /// </summary>
        [XmlIgnore]
        public int Count => (Any?.Length).GetValueOrDefault(0);

        public void Clear() => Any = [];

        /// <summary>
        /// Add an XmlElement to the Any field
        /// </summary>
        /// <param name="element"></param>
        public void Add(System.Xml.XmlElement element)
        {
            if (Any == null)
                Any = new System.Xml.XmlElement[1];
            else
                Array.Resize(ref anyField, anyField.Length + 1);
            Any[anyField.Length - 1] = element;
        }
    }

}
