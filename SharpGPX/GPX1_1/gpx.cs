using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Serialization;

namespace SharpGPX.GPX1_1
{
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class gpxType
    {
        public gpxType()
        {
            metadata = new metadataType();
            rte = new rteTypeCollection();
            wpt = new wptTypeCollection();
            trk = new trkTypeCollection();
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

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class metadataType
    {
        public metadataType() => link = new linkTypeCollection();

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public metadataType(metadataType other)
        {
            author = other.author;
            bounds = new boundsType(other.bounds);
            copyright = new copyrightType(other.copyright);
            desc = other.desc;
            extensions = new extensionsType(other.extensions);
            keywords = other.keywords;
            link = new linkTypeCollection(other.link);
            name = other.name;
            time = other.time;
            timeSpecified = other.timeSpecified;
        }

        internal void Preserialize()
        {
            author?.Preserialize();
            if (author.IsNullOrEmpty()) 
                author = null;

            if (bounds.IsNullOrEmpty())
                bounds = null;

            copyright?.Preserialize();
            if (copyright.IsNullOrEmpty())
                copyright = null;

            if (desc.IsNullOrEmpty())
                desc = null;

            extensions?.Preserialize();
            if (extensions.IsNullOrEmpty())
                extensions = null;

            if (keywords.IsNullOrEmpty())
                keywords = null;

            link?.Preserialize();
            if (link.IsNullOrEmpty())
                link = null;

            if (name.IsNullOrEmpty())
                name = null;

            if (time == DateTime.MinValue)
                timeSpecified = false;
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
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

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
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
            if (name.IsNullOrEmpty()) name = null;

            if (email.IsNullOrEmpty()) email = null;
        }
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
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

            var parts = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
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

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class copyrightType
    {
        public copyrightType() { }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public copyrightType(copyrightType other) 
        {
            author = other.author;
            license = other.license;
            year = other.year;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="author"></param>
        /// <param name="year"></param>
        /// <param name="license"></param>
        public copyrightType(string author, string year = "", string license = "")
        {
            this.author = author;
            this.license = license;
            this.year = year;
        }

        internal void Preserialize()
        {
            if (author.IsNullOrEmpty()) author = null;

            if (license.IsNullOrEmpty()) license = null;

            if (year.IsNullOrEmpty()) year = null;
        }
    }

    /// <summary>
    /// Bounds
    /// </summary>
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("Bounds {maxlat},{maxlon},{minlat},{minlon}")]
    public partial class boundsType
    {
        public boundsType() { }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public boundsType(boundsType other)
        {
            if (other == null) return;
            minlat = other.minlat;
            maxlat = other.maxlat;
            minlon = other.minlon;
            maxlon = other.maxlon;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minlat"></param>
        /// <param name="maxlat"></param>
        /// <param name="minlon"></param>
        /// <param name="maxlon"></param>
        public boundsType(decimal minlat, decimal maxlat, decimal minlon, decimal maxlon)
        {
            this.minlat = minlat;
            this.maxlat = maxlat;
            this.minlon = minlon;
            this.maxlon = maxlon;
        }

        /// <summary>
        /// Make a union of this bounds and the given bounds
        /// </summary>
        /// <returns></returns>
        public boundsType Union(boundsType other)
        {
            if (other == null || other.IsEmpty()) return this;
            if (IsEmpty()) return other;

            maxlat = Math.Max(maxlat, other.maxlat);
            maxlon = Math.Max(maxlon, other.maxlon);
            minlat = Math.Min(minlat, other.minlat);
            minlon = Math.Min(minlon, other.minlon);

            return this;
        }

        /// <summary>
        /// Is this an empty bounds
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => 
            maxlat == decimal.Zero &&
            minlat == decimal.Zero &&
            maxlon == decimal.Zero &&
            minlon == decimal.Zero;

        [XmlIgnore]
        public decimal Width => maxlon - minlon;

        [XmlIgnore]
        public decimal Height => maxlat - minlat;
    }

    /// <summary>
    /// Waypoint
    /// 
    /// Note the fields in this class that have "specified" fields.
    /// 
    /// </summary>
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{DebuggerDisplay, nq}")]
    public partial class wptType
    {
        public wptType()
        {
            timeSpecified = false;
            eleSpecified = false;
            ele = NULL_ELE;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="elevation"></param>
        /// <param name="dateTime"></param>
        public wptType(double latitude, double longitude, double? elevation = null, DateTime? dateTime = null) : this()
        {
            lat = (decimal)latitude;
            lon = (decimal)longitude;

            timeSpecified = dateTime.HasValue;
            if (dateTime.HasValue)
                time = dateTime.Value;

            eleSpecified = elevation.HasValue;
            if (elevation.HasValue)
                ele = (decimal)elevation.Value;
        }

        public static decimal NULL_ELE = -99999;

        internal void Preserialize()
        {
            if (time == DateTime.MinValue)
                timeSpecified = false;

            if (!eleSpecified)
                eleSpecified = (ele != NULL_ELE);

            if (extensions != null && extensions.Count == 0)
                extensions = null;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never), System.ComponentModel.Browsable(false)]
        [XmlIgnore]
        internal string DebuggerDisplay => (ele == NULL_ELE) ? $"{lat}, {lon}" : $"{lat}, {lon}, {ele}m";

    }

    /// <summary>
    /// Point
    /// </summary>
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{DebuggerDisplay, nq}")]
    public partial class ptType
    {
        public ptType()
        {
            timeSpecified = false;
            eleSpecified = false;
            ele = NULL_ELE;
        }

        public static decimal NULL_ELE = -99999;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="elevation"></param>
        /// <param name="dateTime"></param>
        public ptType(double latitude, double longitude, double? elevation = null, DateTime? dateTime = null) : this()
        {
            lat = (decimal)latitude;
            lon = (decimal)longitude;
            eleSpecified = false;

            timeSpecified = dateTime.HasValue;
            if (dateTime.HasValue)
                time = dateTime.Value;

            eleSpecified = elevation.HasValue;
            if (elevation.HasValue)
                ele = (decimal)elevation.Value;
        }

        internal void Preserialize()
        {
            if (time == DateTime.MinValue)
                timeSpecified = false;

            if (!eleSpecified)
                eleSpecified = (ele != NULL_ELE);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never), System.ComponentModel.Browsable(false)]
        [XmlIgnore]
        internal string DebuggerDisplay => (ele == NULL_ELE) ? $"{lat}, {lon}" : $"{lat}, {lon}, {ele}m";
    }

    /// <summary>
    /// Track
    /// </summary>
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{trkseg.Count} segments")]
    public partial class trkType
    {
        public trkType() => trkseg = new trksegTypeCollection();

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

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
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

        public void Clear() => Any = new System.Xml.XmlElement[0];

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

    /// <summary>
    /// Track Segment
    /// </summary>
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{trkpt.Count} points")]
    public partial class trksegType
    {
        public trksegType() => trkpt = new wptTypeCollection();

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

    /// <summary>
    /// Route Type
    /// </summary>
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{rtept.Count} points")]
    public partial class rteType
    {
        public rteType() => rtept = new wptTypeCollection();
        
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

    /// <summary>
    /// Waypoint Collection
    /// </summary>
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class wptTypeCollection
    {
        public wptTypeCollection() { }

        public wptTypeCollection(IEnumerable<wptType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => Count == 0 ? new boundsType() : new boundsType(this.Min(x => x.lat), this.Max(x => x.lat), this.Min(x => x.lon), this.Max(x => x.lon));

        internal void Preserialize() => ForEach(x => x.Preserialize());
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class rteTypeCollection
    {
        public rteTypeCollection() { }

        public rteTypeCollection(IEnumerable<rteType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds()
        {
            boundsType bounds = new boundsType();
            foreach (var rte in this)
                bounds = rte.rtept.GetBounds().Union(bounds);
            return bounds;
        }

        internal void Preserialize() => ForEach(x => x.Preserialize());
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class trkTypeCollection
    {
        public trkTypeCollection() { }

        public trkTypeCollection(IEnumerable<trkType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds()
        {
            boundsType bounds = new boundsType();
            foreach (var trk in this)
                bounds = trk.trkseg.GetBounds().Union(bounds);
            return bounds;
        }

        internal void Preserialize() => ForEach(x => x.Preserialize());
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class linkTypeCollection
    {
        public linkTypeCollection() { }

        public linkTypeCollection(IEnumerable<linkType> collection) : base(collection) { }

        internal void Preserialize() => ForEach(x => x.Preserialize());
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class trksegTypeCollection
    {
        public trksegTypeCollection() { }

        public trksegTypeCollection(IEnumerable<trksegType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds()
        {
            boundsType bounds = new boundsType();
            foreach (var trkSeg in this)
                bounds = trkSeg.trkpt.GetBounds().Union(bounds);
            return bounds;
        }

        internal void Preserialize() => ForEach(x => x.Preserialize());
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class ptTypeCollection
    {
        public ptTypeCollection() { }

        public ptTypeCollection(IEnumerable<ptType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => Count == 0 ? new boundsType() : new boundsType(this.Min(x => x.lat), this.Max(x => x.lat), this.Min(x => x.lon), this.Max(x => x.lon));

        internal void Preserialize() => ForEach(x => x.Preserialize());
    }
}
