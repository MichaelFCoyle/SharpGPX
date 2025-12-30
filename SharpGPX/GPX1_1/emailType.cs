using System;

namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{id}@{domain}")]
    public partial class emailType
    {
        public emailType() { }

        /// <summary>
        /// Copy construcor
        /// </summary>
        /// <param name="other"></param>
        public emailType(emailType other)
        {
            domain = other?.domain;
            id = other?.id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        public emailType(string email)
        {
            if (email.IsNullOrEmpty()) return;

            var parts = email.Split(['@'], StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2) return;

            id = parts[0];
            domain = parts[1];
        }

        internal void Preserialize()
        {
            if (id.IsNullOrEmpty()) id = null;

            if (domain.IsNullOrEmpty()) domain = null;
        }
    }

}
