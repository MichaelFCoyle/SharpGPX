namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{text} ({href})")]
    public partial class linkType
    {
        public linkType() { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public linkType(linkType other)
        {
            href = other?.href;
            text = other?.text;
        }

        /// <summary>
        /// Create a link
        /// </summary>
        /// <param name="link"></param>
        /// <param name="description"></param>
        public linkType(string link, string description = "")
        {
            href = link;
            text = description;
        }

        internal void Preserialize()
        {
            if (href.IsNullOrEmpty()) href = null;

            if (text.IsNullOrEmpty()) text = null;
        }
    }
}
