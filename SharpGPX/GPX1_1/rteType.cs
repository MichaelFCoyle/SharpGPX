namespace SharpGPX.GPX1_1
{
    /// <summary>
    /// Route Type
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{rtept.Count} points")]
    public partial class rteType
    {
        public rteType() => rtept = [];

        public rteType(wptTypeCollection rtept) => this.rtept = rtept;

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => rtept.GetBounds();

        internal void Preserialize()
        {
            rtept.Preserialize();

            if (extensions != null && extensions.Count == 0)
                extensions = null;
        }
    }

}
