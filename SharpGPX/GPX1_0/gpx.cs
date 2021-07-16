using System.Collections.Generic;

namespace SharpGPX.GPX1_0
{

#pragma warning disable IDE1006 // Naming Styles

    public partial class gpx
    {

    }

    public partial class gpxWptCollection
    {
        public gpxWptCollection() { }

        public gpxWptCollection(IEnumerable<gpxWpt> collection) : base(collection) { }
    }

    public partial class gpxRteCollection
    {
        public gpxRteCollection() { }

        public gpxRteCollection(IEnumerable<gpxRte> collection) : base(collection) { }
    }

    public partial class gpxTrkCollection
    {
        public gpxTrkCollection() { }

        public gpxTrkCollection(IEnumerable<gpxTrk> collection) : base(collection) { }
    }

    public partial class gpxRteRteptCollection
    {
        public gpxRteRteptCollection() { }

        public gpxRteRteptCollection(IEnumerable<gpxRteRtept> collection) : base(collection) { }
    }

    public partial class gpxTrkTrksegCollection
    {
        public gpxTrkTrksegCollection() { }

        public gpxTrkTrksegCollection(IEnumerable<gpxTrkTrkseg> collection) : base(collection) { }
    }

    public partial class gpxTrkTrksegTrkptCollection
    {
        public gpxTrkTrksegTrkptCollection() { }

        public gpxTrkTrksegTrkptCollection(IEnumerable<gpxTrkTrksegTrkpt> collection) : base(collection) { }
    }
#pragma warning restore IDE1006 // Naming Styles

}