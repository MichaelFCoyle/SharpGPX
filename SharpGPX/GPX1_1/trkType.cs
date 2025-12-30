namespace SharpGPX.GPX1_1
{
    /// <summary>
    /// Track
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{trkseg.Count} segments")]
    public partial class trkType
    {
        public trkType() => trkseg = [];

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => trkseg.GetBounds();

        internal void Preserialize()
        {
            trkseg.Preserialize();

            if (extensions != null && extensions.Count == 0)
                extensions = null;
        }
    }

}
