using System.Collections.Generic;

namespace SharpGPX.GPX1_1.Topografix
{
    /// <summary>
    /// Helper methods for GPX 1.1
    /// </summary>
    public static class Extensions
    {
        #region TopoGrafix extensions

        public static GpxStyle.lineType GetTopografixLine(this trkType trk) => trk.extensions.Get<GpxStyle.lineType>();

        /// <summary>
        /// Get a lineType from Gpx extensions
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        public static GpxStyle.lineType GetTopografixLine(this extensionsType ext) => ext.Get<GpxStyle.lineType>();

        /// <summary>
        /// Get a fillType from Gpx extensions
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        public static GpxStyle.fillType GetTopografixFill(this extensionsType ext) => ext.Get<GpxStyle.fillType>();

        /// <summary>
        /// Get a textType from Gpx extensions
        /// </summary>
        /// <param name="ext"></param>
        /// <returns></returns>
        public static GpxStyle.textType GetTopografixText(this extensionsType ext) => ext.Get<GpxStyle.textType>();

        #endregion

        /// <summary>
        /// Add an item to a collection fluently
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="wptType"></param>
        /// <returns></returns>
        public static List<T> AddItem<T>(this List<T> collection, T wptType)
        {
            collection.Add(wptType);
            return collection;
        }

        /// <summary>
        /// Add a waypoint to a waypoint collection
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="wptType"></param>
        /// <returns></returns>
        public static wptTypeCollection AddItem(this wptTypeCollection collection, wptType wptType)
        {
            collection.Add(wptType);
            return collection;
        }

        /// <summary>
        /// Add a route to a route collection
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="rteType"></param>
        /// <returns></returns>
        public static rteTypeCollection AddItem(this rteTypeCollection collection, rteType rteType)
        {
            collection.Add(rteType);
            return collection;
        }

        /// <summary>
        /// Add a track to a track collection
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="trkType"></param>
        /// <returns></returns>
        public static trkTypeCollection AddItem(this trkTypeCollection collection, trkType trkType)
        {
            collection.Add(trkType);
            return collection;
        }

        /// <summary>
        /// Add a link to a link collection
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        public static linkTypeCollection AddLink(this linkTypeCollection collection, GPX1_1.linkType link)
        {
            collection.Add(link);
            return collection;
        }

        /// <summary>
        /// Add a track segment to a track segment collection
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="trksegType"></param>
        /// <returns></returns>
        public static trksegTypeCollection AddItem(this trksegTypeCollection collection, trksegType trksegType)
        {
            collection.Add(trksegType);
            return collection;
        }

        /// <summary>
        /// Add a point to a point collection
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="ptType"></param>
        /// <returns></returns>
        public static ptTypeCollection AddItem(this ptTypeCollection collection, ptType ptType)
        {
            collection.Add(ptType);
            return collection;
        }
    }
}
