namespace SharpGPX.GPX1_1
{
    /// <summary>
    /// Track Segment
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{trkpt.Count} points")]
    public partial class trksegType
    {
        public trksegType() => trkpt = [];

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => trkpt.GetBounds();

        internal void Preserialize()
        {
            trkpt.Preserialize();

            if (extensions != null && extensions.Count == 0)
                extensions = null;
        }
    }

}
