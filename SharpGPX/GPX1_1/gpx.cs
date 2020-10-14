using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SharpGPX.GPX1_1 
{
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    public partial class gpxType { }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    public partial class wptTypeCollection 
    {
        public wptTypeCollection() { }

        public wptTypeCollection(IEnumerable<wptType> collection) : base(collection) { }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    public partial class rteTypeCollection 
    {
        public rteTypeCollection() { }

        public rteTypeCollection(IEnumerable<rteType> collection) : base(collection) { }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    public partial class trkTypeCollection 
    {
        public trkTypeCollection() { }

        public trkTypeCollection(IEnumerable<trkType> collection) : base(collection) { }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    public partial class linkTypeCollection 
    {
        public linkTypeCollection() { }

        public linkTypeCollection(IEnumerable<linkType> collection) : base(collection) { }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    public partial class trksegTypeCollection
    {
        public trksegTypeCollection() { }

        public trksegTypeCollection(IEnumerable<trksegType> collection) : base(collection) { }

    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    public partial class ptTypeCollection 
    {
        public ptTypeCollection() { }

        public ptTypeCollection(IEnumerable<ptType> collection) : base(collection) { }
    }
}
