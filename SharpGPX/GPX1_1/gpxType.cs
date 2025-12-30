namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class gpxType
    {
        public gpxType()
        {
            metadata = new metadataType();
            rte = [];
            wpt = [];
            trk = [];
            version = "1.1";
        }

        internal void Preserialize()
        {
            metadata?.Preserialize();
            if (metadata.IsNullOrEmpty())
                metadata = null;

            rte?.Preserialize();
            if (rte.IsNullOrEmpty())
                rte = null;

            wpt?.Preserialize();
            if (wpt.IsNullOrEmpty())
                wpt = null;

            trk?.Preserialize();
            if (trk.IsNullOrEmpty())
                trk = null;
        }
    }

}
