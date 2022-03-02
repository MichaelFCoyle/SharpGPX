using SharpGPX.GPX1_1;
using System.Collections.Generic;
using System.Linq;

namespace SharpGPX
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty(this metadataType metadata)
        {
            if (metadata == null) return true;
            return (metadata.author.IsNullOrEmpty() &&
                metadata.bounds.IsNullOrEmpty() &&
                metadata.copyright.IsNullOrEmpty() &&
                metadata.desc.IsNullOrEmpty() &&
                metadata.extensions.IsNullOrEmpty() &&
                metadata.keywords.IsNullOrEmpty() &&
                metadata.link.IsNullOrEmpty() &&
                metadata.name.IsNullOrEmpty() &&
                metadata.timeSpecified == false);
        }

        public static bool IsNullOrEmpty(this extensionsType extensions) => extensions == null || extensions.Any == null || extensions.Any.Count() == 0;

        public static bool IsNullOrEmpty(this copyrightType copyright) => copyright == null || (copyright.author.IsNullOrEmpty() && copyright.license.IsNullOrEmpty() && copyright.year.IsNullOrEmpty());

        public static bool IsNullOrEmpty(this linkTypeCollection collection) => collection == null || collection.Count == 0;

        public static bool IsNullOrEmpty(this linkType link) => link == null || (link.href.IsNullOrEmpty() && link.text.IsNullOrEmpty() && link.type.IsNullOrEmpty());

        public static bool IsNullOrEmpty(this personType person) => person == null ||
                (person.email.IsNullOrEmpty() &&
                person.link.IsNullOrEmpty() &&
                person.name.IsNullOrEmpty());

        public static bool IsNullOrEmpty(this boundsType bounds) => bounds == null || bounds.IsEmpty();

        public static bool IsNullOrEmpty(this emailType email) => email == null || (email.domain.IsNullOrEmpty() && email.id.IsNullOrEmpty());

        internal static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);

        public static bool IsNullOrEmpty(this rteTypeCollection rteCollection) => rteCollection == null || rteCollection.Count == 0;

        public static bool IsNullOrEmpty(this wptTypeCollection wptCollection) => wptCollection == null || wptCollection.Count == 0;

        public static bool IsNullOrEmpty(this trkTypeCollection trkCollection) => trkCollection == null || trkCollection.Count == 0;

        /// <summary>
        /// Get a deserialized extension if it exists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>(this extensionsType ext) where T : class
        {
            if (ext == null || ext.Any == null || ext.Any.Count() == 0) return null;

            foreach (var element in ext.Any)
            {
                try
                {
                    T item = Utility.Serializer.Deserialize<T>(element);
                    if (item != null)
                        return item;
                }
                catch { }
            }

            return null;
        }

        #region Garmin extensions

        /// <summary>
        /// Get a Garmin Track Extension from a GPX track
        /// </summary>
        /// <param name="trk"></param>
        /// <returns></returns>
        public static GPX1_1.Garmin.TrackExtension_t GetGarminTrackExt(this trkType trk) => trk.extensions.Get<GPX1_1.Garmin.TrackExtension_t>();

        /// <summary>
        /// Get a Garmin Route Extension from a GPX route
        /// </summary>
        /// <param name="rte"></param>
        /// <returns></returns>
        public static GPX1_1.Garmin.RouteExtension_t GetGarminRouteExt(this rteType rte) => rte.extensions.Get<GPX1_1.Garmin.RouteExtension_t>();

        /// <summary>
        /// Get a Garmin Waypoint Extension from a GPX waypoint
        /// </summary>
        /// <param name="wpt"></param>
        /// <returns></returns>
        public static GPX1_1.Garmin.WaypointExtension_t GetGarminWaypointExt(this wptType wpt) => wpt.extensions.Get<GPX1_1.Garmin.WaypointExtension_t>();

        /// <summary>
        /// Get a Garmin Route Point Extension from a GPX waypoint
        /// </summary>
        /// <param name="wpts"></param>
        /// <returns></returns>
        public static GPX1_1.Garmin.RoutePointExtension_t GetGarminRoutePointExt(this wptType wpt) => wpt.extensions.Get<GPX1_1.Garmin.RoutePointExtension_t>();

        #endregion

        #region TopoGrafix extensions

        public static GPX1_1.Topografix.GpxStyle.lineType GetTopografixLine(this trkType trk) => trk.extensions.Get<GPX1_1.Topografix.GpxStyle.lineType>();

        /// <summary>
        /// Get a lineType from Gpx extensions
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        public static GPX1_1.Topografix.GpxStyle.lineType GetTopografixLine(this extensionsType ext) => ext.Get<GPX1_1.Topografix.GpxStyle.lineType>();

        /// <summary>
        /// Get a fillType from Gpx extensions
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        public static GPX1_1.Topografix.GpxStyle.fillType GetTopografixFill(this extensionsType ext) => ext.Get<GPX1_1.Topografix.GpxStyle.fillType>();

        /// <summary>
        /// Get a textType from Gpx extensions
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        public static GPX1_1.Topografix.GpxStyle.textType GetTopografixText(this extensionsType ext) => ext.Get<GPX1_1.Topografix.GpxStyle.textType>();

        #endregion
 
        /// <summary>
        /// Convert a track to several routes.
        /// Each track segment is a seperate route.
        /// Each route has the same name as the track with the words "Segment n" appended
        /// where "n" is the segment number.
        /// </summary>
        /// <param name="track"></param>
        /// <returns></returns>
        public static List<rteType> ToRoutes(this trkType track)
        {
            List<rteType> results = new List<rteType>();

            int i = 0;
            foreach (var seg in track.trkseg)
                results.Add(new rteType()
                {
                    cmt = track.cmt,
                    desc = track.desc,
                    link = track.link,
                    number = track.number,
                    rtept = new wptTypeCollection(seg.trkpt),
                    src = track.src,
                    type = track.type,
                    name = $"{track.name} segment {i++}",
                });

            return results;
        }

        /// <summary>
        /// Conver a single track segment to a route.
        /// </summary>
        /// <param name="seg"></param>
        /// <returns></returns>
        public static rteType ToRoute(this trksegType seg) => new rteType()
        {
            rtept = new wptTypeCollection(seg.trkpt.ToArray())
        };
    }
}
