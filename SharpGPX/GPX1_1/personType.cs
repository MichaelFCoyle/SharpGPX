namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{name} ({email})")]
    public partial class personType
    {
        public personType() { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public personType(personType other)
        {
            name = other?.name;
            email = new emailType(other?.email);
            link = new linkType(other?.link);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        public personType(string name, string email = "")
        {
            this.name = name;
            this.email = new emailType(email);
        }

        internal void Preserialize()
        {
            if (name.IsNullOrEmpty()) 
                name = null;

            if (email.IsNullOrEmpty()) 
                email = null;
        }
    }
}
