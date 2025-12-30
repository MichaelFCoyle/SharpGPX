using System;

namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class metadataType
    {
        public metadataType() => link = [];

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

}
